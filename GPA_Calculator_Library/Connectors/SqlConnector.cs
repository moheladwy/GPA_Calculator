using System.Configuration;
using System.Data;
using Dapper;
using GPA_Calculator_Library.Models;

namespace GPA_Calculator_Library.Connectors
{
    public class SqlConnector
    {
        private const string DbName = "GPA_Calculator";

        public void CreateCourse(CourseModel course)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(
                       GlobalConfig.ConnectionString(DbName)))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@CourseName", course.CourseName);
                parameters.Add("@CreditHours", course.CreditHours);
                parameters.Add("@Grade", course.Grade);
                parameters.Add("@id", 0, dbType: DbType.Int32,
                    direction: ParameterDirection.Output);

                connection.Execute("dbo.Courses_Insert", parameters,
                    commandType: CommandType.StoredProcedure);

                course.Id = parameters.Get<int>("@id");
            }
        }

        public List<CourseModel> GetCourse_All()
        {
            List<CourseModel> output = new();

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(
                       GlobalConfig.ConnectionString(DbName)))
            {
                output = connection.Query<CourseModel>("dbo.spCourses_GetAll",
                    commandType: CommandType.StoredProcedure).ToList();
            }

            return output;
        }
    }
}
