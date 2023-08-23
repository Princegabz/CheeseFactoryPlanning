using System;

namespace CheeseFactoryPlanning
{
    public class Cheese
    {
        private string ID;
        private string strName;
        private string Date;
        private string BBdate;
        private string BatchNumber;
        public Cheese()
        {
            ID = "";
            strName = "";
            Date = "";
            BBdate = "";
            BatchNumber = "";
        }
        public Cheese(String ID, String strName, String Date, String BBdate, String BatchNumber)
        {
            this.ID = ID;
            this.strName = strName;
            this.Date = Date;
            this.BBdate = BBdate;
            this.BatchNumber = BatchNumber;

        }
        public override string ToString()
        {
            return "ID is " + ID + "\n"+
                   " Name is " + strName + "\n" +
                   " Date is " + Date + "\n" +
                   " bbDate is " + BBdate + "\n" +
                   " and lastly Batch Number is " + BatchNumber;
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                {
                    return this.ID;
                }
                else if (index == 1)
                {
                    return this.strName;
                }
                else if (index == 2)
                {
                    return this.Date;
                }
                else if (index == 3)
                {
                    return this.BBdate;
                }
                else if (index == 4)
                {
                    return this.BatchNumber;
                }
                return null;
            }
            set
            {
                if (index == 0)
                {
                    this.ID = (string)value; //forcing the program to know that the datatype is that of a string because it recives an object and doesnt know what it is
                }
                else if (index == 1)
                {
                    this.strName = (string)value;
                }
                else if (index == 2)
                {
                    this.Date = (string)value;
                }
                else if (index == 3)
                {
                    this.BBdate = (string)value;
                }
                else if (index == 4)
                {
                    this.BatchNumber = (string)value;
                }
            }
        }

        public object this[string attrName]
        {
            get
            {
                if (attrName.ToLower().Equals("ID"))
                {
                    return this.ID;
                }
                else if (attrName.ToLower().Equals("strName"))
                {
                    return this.strName;
                }
                else if (attrName.ToLower().Equals("Date"))
                {
                    return this.Date;
                }
                else if (attrName.ToLower().Equals("BBdate"))
                {
                    return this.BBdate;
                }
                else if (attrName.ToLower().Equals("BatchNumber"))
                {
                    return this.BatchNumber;
                }
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("ID"))
                {
                    this.ID = (string)value; ;
                }
                else if (attrName.ToLower().Equals("strName"))
                {
                    this.strName = (string)value; ;
                }
                else if (attrName.ToLower().Equals("Date"))
                {
                    this.Date = (string)value;
                }
                else if (attrName.ToLower().Equals("BBdate"))
                {
                    this.BBdate = (string)value;
                }
                else if (attrName.ToLower().Equals("BatchNumber"))
                {
                    this.BatchNumber = (string)value;
                }
            }
        }
    }
}
