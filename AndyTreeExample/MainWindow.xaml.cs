using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AndyTreeExample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            treeView.ItemsSource = GetData();
        }

        // private List<Composite> GetData()
        //{
        //    List<Composite> list = new List<Composite>()
        //    {
        //        new Composite { Name = "1", Children = new List<Composite>()
        //            {
        //                new Composite { Name = "1.1", Children = new List<Composite>()
        //                    {
        //                        new Composite { Name = "1.1.1" },
        //                        new Composite { Name = "1.1.2" },
        //                        new Composite { Name = "1.1.3" }
        //                    }
        //                },

        //                new Composite { Name = "2.1", Children = new List<Composite>()
        //                    {
        //                        new Composite { Name = "2.1.1" },
        //                        new Composite { Name = "2.1.2" },
        //                        new Composite { Name = "2.1.3" }
        //                    }
        //                }
        //            }
        //        },
        //        new Composite { Name = "3", Children = null }
        //    };
        //    return list;
        //}

        private static List<Composite> GetData()
        {
            List<Composite> list = new List<Composite>()
        {
            new Department { Name = "Division 1", Children = new List<Composite>()
                {
                    new Department { Name = "Finance", Budget = 10, Children  = new List<Composite>()
                        {
                            new Employee { Name = "Tom", Role="Accountant" },
                            new Employee { Name = "Sarah", Role="Accountant" },
                            new Employee { Name = "Harry", Role="Secretary" }
                        }
                    },
                    new Department { Name = "Sales", Children  = new List<Composite>()
                        {
                            new Employee { Name = "Alice", Role="", Salary=11 },
                            new Employee { Name = "Mary", Role="", Salary=11 },
                            new Employee { Name = "Harry", Role="", Salary=11 }
                        }
                    }
                }
            },
            new Department { Name = "Division 2", Children = null }
        };
            return list;
        }



    }
   
       
        public class Composite
        {
            public string Name { get; set; }
            public List<Composite> Children { get; set; }
        }

        public class Department : Composite
        {
                        
            public int Budget {get; set;}
            public string Role { get; set; }
            public int Salary {get; set;}
           

            //public List<Department> Children { get; set; }
            //public List<Employee> Person { get; set; }

        }
        public class Employee : Composite
        {
            public string Role { get; set; }
            public int Salary { get; set; }
        }

        public class Manager : Composite
        {
            
            public List<Composite> Children { get; set; }
        }
}
