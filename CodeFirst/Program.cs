﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst {
    class Program {
        static void Main(string[] args) {
            using (var db=new Context())
            {
                var user = new User();
                user.Name = "fabio";
                db.Users.Add(user);
                db.SaveChanges();
            }
            }
        }
    }
