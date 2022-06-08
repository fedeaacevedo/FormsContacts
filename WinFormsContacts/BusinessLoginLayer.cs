using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsContacts
{
    public class BusinessLoginLayer
    {
        private DataAccesLayer _dataAccesLayer;
        public BusinessLoginLayer()
        {
            _dataAccesLayer = new DataAccesLayer();
        }
        public Contact SaveContact(Contact contact)
        {
            if(contact.Id == 0)
                _dataAccesLayer.InsertContact(contact);
            // else
            // _dataAccesLayer.UpdateContact

            return contact;
        }
    }
}
