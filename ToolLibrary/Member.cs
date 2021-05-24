namespace ToolLibrary
{
    public class Member : iMember
    {
        private string firstName;
        private string lastName;
        private string contactNumber;
        private string pin;
        string[] tools = new string[30];

        public Member(string firstName, string lastName, string contactNumber, string pin)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contactNumber = contactNumber;
            this.pin = pin;
        }

        public string FirstName
        {
            get { return firstName; }
            set { lastName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string ContactNumber
        {
            get { return contactNumber; }
            set { contactNumber = value; }
        }

        public string PIN
        {
            get { return pin; }
            set { pin = value; }
        }

        public string[] Tools
        {
            get { return tools; }
        }

        public void addTool(Tool Tool)
        {
            for (int i = 0; i  < Tools.Length; i++)
            {
                if (Tools[i] == null)
                {
                    Tools[i] = Tool.Name;
                    break;
                }
            }
        }

        public void deleteTool(Tool Tool)
        {
            string[] tempTools = new string[30];
            bool found = false;

            for (int i = 0; i < Tools.Length; i++)
            {
                if (Tools[i] != null)
                {
                    if (!found)
                    {
                        if (Tools[i] != Tool.Name)
                        {
                            tempTools[i] = Tools[i];
                        }
                        else
                        {
                            found = true;
                        }
                    }
                    else
                    {
                        tempTools[i - 1] = Tools[i];
                    }

                }
                else
                    break;
            }

            tools = tempTools;
        }

        public override string ToString()
        {
            return string.Join(", ", FirstName, LastName, ContactNumber);
        }
    }
}
