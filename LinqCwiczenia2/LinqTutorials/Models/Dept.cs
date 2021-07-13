namespace LinqTutorials.Models
{
    public class Dept
    {
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }

        override
        public string ToString() {
            return Deptno + " " + Dname + " " + Loc;
        }
    }
}