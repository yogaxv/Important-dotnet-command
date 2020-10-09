using Microsoft.AspNetCore.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using e_property.Models;

namespace e_property.Data
{
    public interface ICommanderRepo
    {
        IEnumerable<Command> GetCommands();
        Command GetCommandById(int id);
    }
}
