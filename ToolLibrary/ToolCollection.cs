using System;

namespace ToolLibrary
{
    public class ToolCollection : iToolCollection
    {
        private int number = 0;
        private Tool[] tools = new Tool[30];

        public int Number
        {
            get { return number; }
        }

        public void add(Tool Tool)
        {
            bool exists = false;

            for (int i = 0; i < number; i++)
            {
                if (tools[i] != null)
                {
                    if (tools[i].Name == Tool.Name)
                    {
                        exists = true;
                        tools[i] = Tool;
                    }
                }
            }

            if (!exists)
            {
                number += 1;
                tools[Number - 1] = Tool;
            }
        }

        public void delete(Tool Tool)
        {
            Tool[] tempTools = new Tool[30];
            bool found = false;

            for (int i = 0; i < Number; i++)
            {
                if (tools[i] != null)
                {
                    if (!found)
                    {
                        if (tools[i] != Tool)
                        {
                            tempTools[i] = tools[i];
                        }
                        else
                        {
                            found = true;
                            number -= 1;
                        }
                    }
                    else
                    {
                        tempTools[i - 1] = tools[i];
                    }
                }
                else
                    break;
            }

            tools = tempTools;
        }

        public bool search(Tool Tool)
        {
            for (int i = 0; i < tools.Length; i++)
            {
                if (tools[i] == Tool)
                {
                    return true;
                }
            }

            return false;
        }

        public Tool[] toArray()
        {
            return tools;
        }
    }
}
