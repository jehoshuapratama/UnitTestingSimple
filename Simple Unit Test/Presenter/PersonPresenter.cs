using Simple_Unit_Test.View.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Unit_Test.Presenter
{
    public class PersonPresenter
    {
        private readonly IPersonView? _personView;
        public PersonPresenter(IPersonView personView)
        {
            _personView = personView;
            personView.Presenter = this;
        }

        public void InitialMessage()
        {
            _personView!.Message = "WELCOME! \nFill all the details!";
        }

        public void ClearBox()
        {
            _personView!.FirstName = string.Empty;
            _personView.LastName = string.Empty;
            _personView.PhoneNumber = string.Empty;
            _personView.Email = string.Empty;
            _personView.Nationality = string.Empty;
        }

        public void Submit()
        {
            if (_personView!.FirstName == ""
                || _personView.LastName == ""
                || _personView.Email == ""
                || _personView.PhoneNumber == ""
                || _personView.Nationality == "")
            {
                _personView.Message = "Fill all the details correctly";
                return;
            }
            else
            {
                bool emailValid = CheckEmail();
                bool phoneValid = CheckPhoneNumber();

                if (emailValid && phoneValid)
                {
                    _personView.Message = "Details added!";
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        public bool CheckEmail()
        {
            if (!_personView!.Email.Contains('@'))
            {
                _personView.Message = "Email is not Valid";
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckPhoneNumber()
        {
            var isNumeric = int.TryParse(_personView!.PhoneNumber, out int n);
            if(!isNumeric)
            {
                if(_personView.Message != "")
                {
                    _personView.Message += " and Phone Number must be all Number";
                }
                else
                {
                    _personView.Message = "Phone Number must be all Number";
                }
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
