using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GPA_Calculator_Library.Models;

namespace GPA_Calculator_Library.Connectors
{
    public interface ICourseRequestor
    {
        void CourseComplete(CourseModel model);
    }
}
