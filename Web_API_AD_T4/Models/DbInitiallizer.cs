using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using DI.Core.Data;
using DI.Data;

namespace Web_API_AD_T4.Models
{
    public class DbInitiallizer:DropCreateDatabaseAlways<IDbContext>
    {
        private static UnitOfWork uow= new UnitOfWork();
       
        protected override void Seed(IDbContext context)
        {
            var _Catrgories = new List<Category>
            {
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Pen",AddedDate = DateTime.Now,CategoryCode = "P01",ModifiedDate = DateTime.Today},
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Clip",AddedDate = DateTime.Now,CategoryCode = "C01",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Eraser",AddedDate = DateTime.Now,CategoryCode = "E01",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Exercise",AddedDate = DateTime.Now,CategoryCode = "E02",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Envelope",AddedDate = DateTime.Now,CategoryCode = "E03",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "File",AddedDate = DateTime.Now,CategoryCode = "F01",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Puncher",AddedDate = DateTime.Now,CategoryCode = "P02",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Pad",AddedDate = DateTime.Now,CategoryCode = "P03",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Paper",AddedDate = DateTime.Now,CategoryCode = "P04",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Ruler",AddedDate = DateTime.Now,CategoryCode = "R01",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Scissors",AddedDate = DateTime.Now,CategoryCode = "S01",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Tape",AddedDate = DateTime.Now,CategoryCode = "T01",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Sharpener",AddedDate = DateTime.Now,CategoryCode = "S02",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Shorthand",AddedDate = DateTime.Now,CategoryCode = "S03",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Stapler",AddedDate = DateTime.Now,CategoryCode = "S04",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Tacks",AddedDate = DateTime.Now,CategoryCode = "T02",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Tparency",AddedDate = DateTime.Now,CategoryCode = "T03",ModifiedDate = DateTime.Today },
                new Category { ID = Guid.NewGuid(),CategoryDescription = "Tray",AddedDate = DateTime.Now,CategoryCode = "T04",ModifiedDate = DateTime.Today },
            };
            foreach (var _category in _Catrgories)
            {

                uow.Repository<Category>().Insert(_category);
            }

            var _Stocks=new List<Stock>
            {
                new Stock {ID = Guid.NewGuid(),ItemCode ="C001",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("C01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Clips Double 1",Price = 10,ReoderQty = 30,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="C004",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("C01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Clips Paper Large",Price = 10,ReoderQty = 30,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="C005",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("C01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Clips Paper Medium",Price = 10,ReoderQty = 30,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="C004",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("C01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Clips Paper Small",Price = 10,ReoderQty = 30,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="E001",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Envelope Brown(3*6)",Price = 8,ReoderQty = 400,ReorderLevelQty = 600,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="E002",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Envelope Brown(3*6) w/Window",Price = 8,ReoderQty = 400,ReorderLevelQty = 600,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="E003",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Envelope Brown(5*7)",Price = 8,ReoderQty = 400,ReorderLevelQty = 600,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="E004",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Envelope Brown(5*7 w/Window)",Price = 8,ReoderQty = 400,ReorderLevelQty = 600,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="E020",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Eraser(hard)",Price = 2,ReoderQty = 20,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="E021",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Eraser(soft)",Price = 2,ReoderQty = 20,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="E030",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Exercise Book(100pg)",Price = 4,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="E031",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Exercise Book (120pg)",Price = 5,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="E032",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("E02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Exercise Book A4 Hardcover(100pg)",Price = 5,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="F020",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("F01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "File Separator",Price = 5,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="F021",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("F01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "File-Blue Plain",Price = 5,ReoderQty = 100,ReorderLevelQty = 200,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="F022",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("F01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "File-Blue with Logo",Price = 5,ReoderQty = 100,ReorderLevelQty = 200,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="H011",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("P01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Highlighter Blue",Price = 2,ReoderQty = 80,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="P030",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("P01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Pen Ballpoint Black",Price = 2,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="P033",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("P01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Pen Felt Tip Black",Price = 2,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="P036",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("P01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Pen Transparency Permanent",Price = 2,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="H031",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("P02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Hole Puncher 2 holes",Price = 2,ReoderQty = 20,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="P010",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("P03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Pad Posit Memo 1*2",Price = 3,ReoderQty = 60,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="P011",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("P03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Pad Posit Memo 2*4",Price = 3,ReoderQty = 60,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="R001",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("R01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Ruler 12",Price = 5,ReoderQty = 50,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="S100",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("S01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Scissors",Price = 10,ReoderQty = 20,ReorderLevelQty = 60,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="S101",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("S02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Sharpener",Price = 15,ReoderQty = 20,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="S010",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("S03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Shorthand Book(100pg)",Price = 10,ReoderQty = 80,ReorderLevelQty = 100,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="S020",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("S04")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Stapler No.28",Price = 5,ReoderQty = 20,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="S021",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("S04")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Stapler No.36",Price = 6,ReoderQty = 20,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="S040",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T01")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Tape",Price = 5,ReoderQty = 20,ReorderLevelQty = 50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="T001",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Thumb Tacks Large",Price = 5,ReoderQty = 10,ReorderLevelQty = 10,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="T002",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Thumb Tacks Medium",Price = 4,ReoderQty = 10,ReorderLevelQty = 10,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="T003",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T02")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Thumb Tacks Small",Price = 3,ReoderQty = 10,ReorderLevelQty = 10,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="T020",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Transparency Blue",Price = 2,ReoderQty = 100,ReorderLevelQty = 200,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="T021",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Transparency Clear",Price = 2,ReoderQty = 200,ReorderLevelQty = 400,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                new Stock {ID = Guid.NewGuid(),ItemCode ="T022",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T03")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Transparency Green",Price = 2,ReoderQty = 200,ReorderLevelQty = 400,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                new Stock {ID = Guid.NewGuid(),ItemCode ="T100",CategoryId = _Catrgories.Where(x => x.CategoryCode.Equals("T04")).Select(x => x.ID).FirstOrDefault(),ItemDescription = "Trays In/Out",Price = 10,ReoderQty = 10,ReorderLevelQty = 20,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

            };
            foreach (var _stock in _Stocks)
            {
                uow.Repository<Stock>().Insert(_stock);
            }

             var _StockCard=new List<StockCard>
             {
                 new StockCard {ID = Guid.NewGuid(),StockId = _Stocks.Where(x=>x.ItemCode.Equals("H011")).Select(x=>x.ID).FirstOrDefault(),Description ="Supplier-BANE",TransDate =Convert.ToDateTime("02/01/2000"),BalanceQty = 550,Qty = +550,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                 new StockCard {ID = Guid.NewGuid(),StockId = _Stocks.Where(x=>x.ItemCode.Equals("H011")).Select(x=>x.ID).FirstOrDefault(),Description ="English Department",TransDate = Convert.ToDateTime("05/01/2000"),BalanceQty = 530,Qty =-20,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                 new StockCard {ID = Guid.NewGuid(),StockId = _Stocks.Where(x=>x.ItemCode.Equals("H011")).Select(x=>x.ID).FirstOrDefault(),Description ="Administration Deparment",TransDate = Convert.ToDateTime("07/01/2000"),BalanceQty = 500,Qty = -30,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},

                 new StockCard {ID = Guid.NewGuid(),StockId = _Stocks.Where(x=>x.ItemCode.Equals("P030")).Select(x=>x.ID).FirstOrDefault(),Description ="Supplier-BANE",TransDate = Convert.ToDateTime("02/01/2000"),BalanceQty = 50,Qty = +50,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                 new StockCard {ID = Guid.NewGuid(),StockId = _Stocks.Where(x=>x.ItemCode.Equals("P030")).Select(x=>x.ID).FirstOrDefault(),Description ="Commerce Department",TransDate =Convert.ToDateTime("04/01/2000"),BalanceQty = 40,Qty =-10,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today},
                 new StockCard {ID = Guid.NewGuid(),StockId = _Stocks.Where(x=>x.ItemCode.Equals("P030")).Select(x=>x.ID).FirstOrDefault(),Description ="Computer Science",TransDate =Convert.ToDateTime("09/01/2000"),BalanceQty = 35,Qty = -5,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today}

             };
            foreach (var _stockCard in _StockCard)
            {
                uow.Repository<StockCard>().Insert(_stockCard);
            }
            base.Seed(context);
        }
       

    }
}