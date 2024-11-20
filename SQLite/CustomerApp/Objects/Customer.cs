﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLitePCL;
using SQLite;
using System.Windows.Controls;

namespace CustomerApp.Objects {
    public class Customer {
        [PrimaryKey, AutoIncrement]
        public int Id {
            get; set;
        }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name {
            get; set;
        }

        /// <summary>
        /// 電話番号
        /// </summary>
        public string Phone {
            get; set;
        }

        /// <summary>
        /// 住所
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 写真
        /// </summary>
        public Image Picture {
            get; set;
        }

        public override string ToString() {
            return $"{Id}   {Name}   {Phone}   {Address}   {Picture}";
        }
    }
}