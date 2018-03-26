/****************************** Module Header ******************************\
* Module Name:       Program.cs
* Project:           CSThreadingMonitor
* Copyright (c) Microsoft Corporation.
* 
* This sample shows how to use Monitor to synchronize threads
* 
* This source is subject to the Microsoft Public License.
* See http://www.microsoft.com/en-us/openness/resources/licenses.aspx#MPL.
* All other rights reserved.
* 
* THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY KIND, 
* EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE IMPLIED 
* WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR PURPOSE.
\***************************************************************************/


using System;
using System.Threading;

namespace CSThreadingMonitor
{
    internal class Program
    {
        private static void Main()
        {
            var cell = new Cell();

            var prod = new CellProducer(cell, 20);
            var cons = new CellConsumer(cell, 20);

            var producer = new Thread(prod.ProducerThreadRun);
            var consumer = new Thread(cons.ConsumerThreadRun);

            try
            {
                producer.Start();
                consumer.Start();

                producer.Join();
                consumer.Join();

            }
            catch (ThreadStateException e)
            {
                Console.WriteLine(e);
            }
            catch (ThreadInterruptedException e)
            {
                Console.WriteLine(e);
            }
        }
    }

    public class CellProducer
    {
        private readonly Cell _cell;
        private readonly int _quantity;

        public CellProducer(Cell box, int request)
        {
            _cell = box;
            _quantity = request;
        }

        public void ProducerThreadRun()
        {
            for (var i = 1; i <= _quantity; i++)
            {
                _cell.WriteToCell(i);
                Thread.Sleep(TimeSpan.FromSeconds(1));
            }
        }
    }

    public class CellConsumer
    {
        private readonly Cell _cell;
        private readonly int _quantity;

        public CellConsumer(Cell box, int request)
        {
            _cell = box;
            _quantity = request;
        }

        public void ConsumerThreadRun()
        {
            for (var i = 1; i <= _quantity; i++)
            {
                _cell.ReadFromCell();
            }
        }
    }

    public class Cell
    {
        private int _cellContents;         
        private bool _readyForReadingFromCell;  

        public int ReadFromCell()
        {
            lock (this)
            {
                if (!_readyForReadingFromCell)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }

                Console.WriteLine("Consume: {0}", _cellContents);

                _readyForReadingFromCell = false;
                Monitor.Pulse(this);
            }

            return _cellContents;
        }

        public void WriteToCell(int n)
        {
            lock (this)
            {
                if (_readyForReadingFromCell)
                {
                    try
                    {
                        Monitor.Wait(this);
                    }
                    catch (SynchronizationLockException e)
                    {
                        Console.WriteLine(e);
                    }
                    catch (ThreadInterruptedException e)
                    {
                        Console.WriteLine(e);
                    }
                }

                _cellContents = n;
                Console.WriteLine("Produce: {0}", _cellContents);

                _readyForReadingFromCell = true;
                Monitor.Pulse(this);
            }
        }
    }
}
