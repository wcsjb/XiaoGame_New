﻿using System.Collections;
using System.Collections.Generic;

namespace RedStone.Data
{
    public class RoomData : DataBase
    {
        public string battleServerSessionID { get; private set; }
        public BattleServerData battleServer { get { return ProxyManager.instance.GetProxy<BattleServerProxy>().GetData(battleServerSessionID); } }
        public string name { get; private set; }
        public int id { get; private set; }
        public IList<long> users { get; private set; }
        public IList<Message.PlayerTokenInfo> userTokens { get; private set; }

        public RoomData()
        {
            users = new List<long>();
        }

        public void SetData(string battleServerSessionID, int id, IList<Message.PlayerTokenInfo> tokens, string name)
        {
            this.battleServerSessionID = battleServerSessionID;
            this.id = id;
            this.name = name;
            userTokens = tokens;
        }

        public void SetUsers(List<long> users)
        {
            this.users = users;
        }

        public void RemoveUser(long uid)
        {
            users.Remove(uid);
        }
    }
}