using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace AddressBook
{
    class Contact
    {

        private string fname;
        private string lname;
        private string address;
        private string city;
        private string state;
        private long zip;
        private long phoneNo;
        private string emailId;
        private readonly int n;


        public Contact(string fname, string lname, string address, string city, string state, long zip, long phoneNo, string emailId)
        {
            this.fname = fname;
            this.lname = lname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNo = phoneNo;
            this.emailId = emailId;
        }
        public Contact()
        {
        }

        public void setFname(string fname)
        {
            this.fname = fname;
        }
        public string getFname()
        {
            return fname;
        }
        public void setLname(string lname)
        {
            this.lname = lname;
        }
        public string getLname()
        {
            return lname;
        }
        public void setAdd(string address)
        {
            this.address = address;
        }
        public string getAdd()
        {
            return address;
        }
        public void setCity(string city)
        {
            this.city = city;
        }
        public string getCity()
        {
            return city;
        }
        public void setState(string state)
        {
            this.state = state;
        }
        public string getState()
        {
            return state;
        }
        public void setZip(long zip)
        {
            this.zip = zip;
        }
        public long getZip()
        {
            return zip;
        }
        public void setPhoneNo(long phoneNo)
        {
            this.phoneNo = phoneNo;
        }
        public long getPhoneNo()
        {
            return phoneNo;
        }
        public void setEmailId(string emailId)
        {
            this.emailId = emailId;
        }
        public string getEmailId()
        {
            return emailId;
        }

        public override string ToString()
        {
            return "First Name: " + fname + ", " + "Last Name: " + lname + ", " + "Address: " + address + ", " + "City: " + city + ", " + "State: " + state + ", " + "Zip: " + zip + ", Phone Number: " + phoneNo + ", Email-id: " + emailId;
        }
        public override bool Equals(Object obj)
        {
            //Check for null and compare run-time types.
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                Contact p = (Contact)obj;
                return (fname == p.fname) && (lname == p.lname);
            }
        }
        public override int GetHashCode()
        {
            return n;
        }
        public void SortByCity(List<Contact> contacts)
        {
            contacts.Sort((contact1, contact2) => contact1.city.CompareTo(contact2.city));
        }
        public void SortByState(List<Contact> contacts)
        {
            contacts.Sort((contact1, contact2) => contact1.state.CompareTo(contact2.state));
        }
        public void SortByZip(List<Contact> contacts)
        {
            contacts.Sort((contact1, contact2) => contact1.zip.CompareTo(contact2.zip));
        }

    }
}