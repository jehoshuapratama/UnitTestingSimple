using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Unit_Test.View.Interfaces
{
    public interface IPersonView
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Email { get; set; }
        string PhoneNumber { get; set; }
        string Nationality { get; set; }
        string Message { get; set; }
        bool EmailFocus { get; }
        bool PhoneNumberFocus { get; }
        Presenter.PersonPresenter Presenter { set; }
    }
}
