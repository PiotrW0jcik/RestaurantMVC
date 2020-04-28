using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PiotrWojcik.Restaurant.Models
{
    public class TableModel
    {
        private List<Table> tables;

        public TableModel()
        {
            this.tables = new List<Table>() {
                new Table() {
                    Id = 1,
                    Name = "Stolik nr.1",
                },
                new Table() {
                    Id = 2,
                    Name = "Stolik nr.2",
                    
                },
                new Table() {
                    Id = 3,
                    Name = "Stolik nr.3",
                },
                new Table() {
                    Id = 4,
                    Name = "Stolik nr.4",
                },
                new Table() {
                    Id = 5,
                    Name = "Stolik nr.5",
                },

            };
        }

        public List<Table> findAll()
        {
            return this.tables;
        }

        public Table find(int id)
        {
            return this.tables.Single(p => p.Id.Equals(id));
        }   

    }
}