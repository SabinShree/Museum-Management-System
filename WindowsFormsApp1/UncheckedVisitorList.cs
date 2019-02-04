using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public class UncheckedVisitorList
    {
        private static UncheckedVisitorList instance;
        private List<Visitor> _visitors = new List<Visitor>();

        private UncheckedVisitorList()
        {
            
        }
       
        public static UncheckedVisitorList UncheckedVisitor
        {
            get { return instance ?? (instance = new UncheckedVisitorList()); }
        }
    }
}