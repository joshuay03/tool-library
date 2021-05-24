using System;

namespace ToolLibrary
{
    public class MemberCollection : iMemberCollection
    {
        private int number = 0;
        private BSTree Members = new();

        public int Number
        {
            get { return number; }
        }

        public void add(Member Member)
        {
            Members.Insert(Member);
            number += 1;
        }

        public void delete(Member Member)
        {
            if (Member.Tools[0] == null)
            {
                Members.Delete(Member);
                number -= 1;
            }
        }

        public Boolean search(Member Member)
        {
            return Members.Search(Member);
        }

        public Member[] toArray()
        {
            return Members.ToArray();
        }
    }
}