using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Student
    {
        public Student()
        {
            _totalCount++;
            No = _totalCount;
        }

        public string FullName;
        public int No { get; }
        private string _groupNo;
        public int TotalCount => _totalCount; 
        private int _totalCount;
        public int count;
        
        
        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                    _groupNo = value;

            }
        }
        public static bool CheckGroupNo(string groupNo)
        {
            if (!string.IsNullOrEmpty(groupNo) && groupNo.Length == 4)
            {
                if (Char.IsLetter(groupNo[0]))
                {
                    for (int i = 0; i < groupNo.Length; i++)
                    {
                        if (!char.IsDigit(groupNo[i]))
                            return false;
                    }
                    return true;
                }

            }
                return false;         
        }
    }
}
