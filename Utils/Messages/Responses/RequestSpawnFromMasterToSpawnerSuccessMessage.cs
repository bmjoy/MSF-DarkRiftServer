﻿using System.Text;
using DarkRift;

namespace Utils.Messages.Responses
{
    public class RequestSpawnFromMasterToSpawnerSuccessMessage : ResponseMessage
    {
        public int SpawnTaskID;
        public int ProcessID;
        public string Arguments;

        public override void Serialize(SerializeEvent e)
        {
            base.Serialize(e);
            e.Writer.Write(SpawnTaskID);
            e.Writer.Write(ProcessID);
            e.Writer.Write(Arguments, Encoding.Unicode);
        }

        public override void Deserialize(DeserializeEvent e)
        {
            base.Deserialize(e);
            SpawnTaskID = e.Reader.ReadInt32();
            ProcessID = e.Reader.ReadInt32();
            Arguments = e.Reader.ReadString(Encoding.Unicode);
        }
    }
}