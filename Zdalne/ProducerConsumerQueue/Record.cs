﻿namespace ProducerConsumerQueue
{
    public class Record
    {
        public readonly string Id;
        public readonly int Value;

        public Record(string id, int value)
        {
            this.Id = id;
            this.Value = value;
        }
    }
}