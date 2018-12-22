namespace MyLib
{
    public class Class1
    {
        private readonly IEmployee _emp;

        public Class1(IEmployee emp)
        {
            this._emp = emp;
        }

        public void GoBug()
        {
            var employee = this._emp.Get(); // it won't stop there even it set a breakpoint

            int a = 1; //set breakpoint here. To see employee obj. It is null.

            int id = employee.Id;
        }
    }

    public interface IEmployee
    {
        Employee Get();
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}