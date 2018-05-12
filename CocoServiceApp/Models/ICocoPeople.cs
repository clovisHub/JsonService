using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocoServiceApp.Models
{
    public interface ICocoPeople
    {
        String insert(ICocoPeople people);

        Boolean delete(Int16 poepleId);

        List<ICocoPeople> getPeoples();

        ICocoPeople getPeople(String name);

        Boolean upDatePeople(int id);
        
    }
}