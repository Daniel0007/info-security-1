﻿

namespace users_files
{
    class user
    {
        private string name;
        private int count;
        public string Name { get { return name; } }
        public int Count { get { return count; } }
        public user(string n, int c)
        {
            name = n;
            count = c;
        }
    }
}
