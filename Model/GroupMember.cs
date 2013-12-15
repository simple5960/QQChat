﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Model
{
   public class GroupMember
    {
        private int groupId;
        public int GroupId
        {
            get { return this.groupId; }
            set { this.groupId = value; }
        }

        private int uId;
        public int UId
        {
            get { return this.uId; }
            set { this.uId = value; }
        }

        private DateTime? time;
        public DateTime? Time
        {
            get {return time;}
            set { this.time = value; }
        }
    }
}
