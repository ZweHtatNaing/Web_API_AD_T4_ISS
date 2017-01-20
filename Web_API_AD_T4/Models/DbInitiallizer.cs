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
        private static UnitOfWork Uow= new UnitOfWork();
       
        protected override void Seed(IDbContext context)
        {
            #region " Bin "

            var _Bins = new List<Bin>
            {
                new Bin { ID = Guid.NewGuid(), BinCode = "A1", BinDescription = "A1", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Bin { ID = Guid.NewGuid(), BinCode = "A2", BinDescription = "A2", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Bin { ID = Guid.NewGuid(), BinCode = "A3", BinDescription = "A3", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Bin { ID = Guid.NewGuid(), BinCode = "B1", BinDescription = "B1", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Bin { ID = Guid.NewGuid(), BinCode = "B2", BinDescription = "B2", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Bin { ID = Guid.NewGuid(), BinCode = "B3", BinDescription = "B3", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Bin { ID = Guid.NewGuid(), BinCode = "B4", BinDescription = "B4", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
            };
            foreach (var _Bin in _Bins)
            {
                Uow.Repository<Bin>().Insert(_Bin);
            }

            #endregion

            #region " UOM "

            var _Uoms = new List<UOM>
            {
                new UOM { ID = Guid.NewGuid(), UomDescription = "Dozen", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UOM { ID = Guid.NewGuid(), UomDescription = "Box", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UOM { ID = Guid.NewGuid(), UomDescription = "Each", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UOM { ID = Guid.NewGuid(), UomDescription = "Set", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UOM { ID = Guid.NewGuid(), UomDescription = "Packet", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
            };
            foreach (var _Uom in _Uoms)
            {
                Uow.Repository<UOM>().Insert(_Uom);
            }

            #endregion

            #region " Category "

            var _Categories = new List<Category>
            {
                new Category { ID = Guid.NewGuid(), CategoryCode = "C01", CategoryDescription = "Clip", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "E01", CategoryDescription = "Envelope", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "E02", CategoryDescription = "Eraser", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "E03", CategoryDescription = "Exercise", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "F01", CategoryDescription = "File", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "P01", CategoryDescription = "Pen", AddedDate = DateTime.Now.Date.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "P02", CategoryDescription = "Puncher", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "P03", CategoryDescription = "Pad", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "P04", CategoryDescription = "Paper", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "R01", CategoryDescription = "Ruler", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "S01", CategoryDescription = "Scissors", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "S02", CategoryDescription = "Sharpener", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "S03", CategoryDescription = "Shorthand", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "S04", CategoryDescription = "Stapler", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "T01", CategoryDescription = "Tape", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "T02", CategoryDescription = "Tacks", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "T03", CategoryDescription = "Tparency", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date },
                new Category { ID = Guid.NewGuid(), CategoryCode = "T04", CategoryDescription = "Tray", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Today.Date }
            };
            foreach (var _Category in _Categories)
            {
                Uow.Repository<Category>().Insert(_Category);
            }

            #endregion

            #region " Stock "

            var _Stocks = new List<Stock>
            {
                new Stock { ID = Guid.NewGuid(), ItemCode ="C001", ItemDescription = "Clips Double 1",
                            CategoryId = _Categories.Where(x => x.CategoryCode.Equals("C01")).Select(x => x.ID).FirstOrDefault(),
                            BinCode = _Bins.Where(x => x.BinCode.Equals("A1")).Select(x => x.ID).FirstOrDefault(),
                            ReorderLevelQty = 50, ReoderQty = 30, UomCode = _Uoms.Where(x => x.UomDescription.Equals("Dozen")).Select(x => x.ID).FirstOrDefault(),
                            Price = 10, AddedDate = DateTime.Today.Date, ModifiedDate = DateTime.Today.Date },

                new Stock {ID=Guid.NewGuid(),ItemCode="C002",ItemDescription="Clips Double 2",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("C01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=30,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Dozen")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="C003",ItemDescription="Clips Double 3/4",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("C01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=30,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Dozen")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="C004",ItemDescription="Clips Paper Large",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("C01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=30,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=30,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="C005",ItemDescription="Clips Paper Medium",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("C01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=30,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=20,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="C006",ItemDescription="Clips Paper Small",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("C01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=30,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//End Clip - A1
                

                //Start Envelope
                new Stock {ID=Guid.NewGuid(),ItemCode="E001",ItemDescription="Envelope Brown (3*6)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E002",ItemDescription="Envelope Brown (3*6) w/Window",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },


                 new Stock {ID=Guid.NewGuid(),ItemCode="E003",ItemDescription="Envelope Brown (5*7)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=12,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                  new Stock {ID=Guid.NewGuid(),ItemCode="E004",ItemDescription="Envelope Brown (5*7) w/Window",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                   new Stock {ID=Guid.NewGuid(),ItemCode="E005",ItemDescription="Envelope White (3*6)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=12,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                 new Stock {ID=Guid.NewGuid(),ItemCode="E006",ItemDescription="Envelope White (3*6) w/Window",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                 new Stock {ID=Guid.NewGuid(),ItemCode="E007",ItemDescription="Envelope White (5*7)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=12,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },
                new Stock {ID=Guid.NewGuid(),ItemCode="E008",ItemDescription="Envelope White (5*7) w/Window",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=600,ReoderQty=400,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//End Envelope

                //Start Eraser
                new Stock {ID=Guid.NewGuid(),ItemCode="E020",ItemDescription="Eraser (hard)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E02")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E021",ItemDescription="Eraser (soft)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E02")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=6,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//End Eraser

                new Stock {ID=Guid.NewGuid(),ItemCode="E030",ItemDescription="Exercise Book (100 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=9,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E031",ItemDescription="Exercise Book (120 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=12,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E032",ItemDescription="Exercise Book A4 Hardcover (100 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=12,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E033",ItemDescription="Exercise Book A4 Hardcover (120 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=12,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E034",ItemDescription="Exercise Book A4 Hardcover (200 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=14,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E035",ItemDescription="Exercise Book Hardcover (100 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="E036",ItemDescription="Exercise Book Hardcover (120 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("E03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=9,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end exercise

                new Stock {ID=Guid.NewGuid(),ItemCode="F020",ItemDescription="File Separator",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=50,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Set")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F021",ItemDescription="File-Blue Plain",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=100,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=6,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F022",ItemDescription="File-Blue with Logo",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=100,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F023",ItemDescription="File-Brown w/o Logo",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=150,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=6,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F024",ItemDescription="File-Brown with Logo",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=150,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=6,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F031",ItemDescription="Folder Plastic Blue",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=150,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F032",ItemDescription="Folder Plastic Clear",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=150,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=7,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },


                new Stock {ID=Guid.NewGuid(),ItemCode="F033",ItemDescription="Folder Plastic Green",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=150,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F034",ItemDescription="Folder Plastic Pink",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=150,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="F035",ItemDescription="Folder Plastic Yellow",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("F01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("A3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=200,ReoderQty=150,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=8,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end File

                new Stock {ID=Guid.NewGuid(),ItemCode="H011",ItemDescription="Highlighter Blue",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=80,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=15,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="H012",ItemDescription="Highlighter Green",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=80,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=15,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="H013",ItemDescription="Highlighter Pink",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=80,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=15,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="H014",ItemDescription="Highlighter Yellow",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=80,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=15,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//End Pen

                new Stock {ID=Guid.NewGuid(),ItemCode="H031",ItemDescription="Hole Puncher 2 holes",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P02")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="H032",ItemDescription="Hole Puncher 3 holes",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P02")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="H033",ItemDescription="Hole Puncher Adjustable",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P02")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//Puncher

                new Stock {ID=Guid.NewGuid(),ItemCode="P010",ItemDescription="Pad Postit Memo 1*2",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=60,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Packet")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="P011",ItemDescription="Pad Postit Memo 1/2*1",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=60,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Packet")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="P012",ItemDescription="Pad Postit Memo 1/2*2",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=60,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Packet")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="P013",ItemDescription="Pad Postit Memo 2*3",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=60,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Packet")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="P014",ItemDescription="Pad Postit Memo 2*4",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=60,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Packet")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="P015",ItemDescription="Pad Postit Memo 2*4",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=60,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Packet")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="P016",ItemDescription="Pad Postit Memo 3/4*2",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=60,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Packet")).Select(x=>x.ID).FirstOrDefault(),
                            Price=5,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end pad

                new Stock {ID=Guid.NewGuid(),ItemCode="P020",ItemDescription="Paper Photostat A3",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P04")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=500,ReoderQty=500,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=17,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="P021",ItemDescription="Paper Photostat A4",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("P04")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B1")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=500,ReoderQty=500,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=17,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end paper

                new Stock {ID=Guid.NewGuid(),ItemCode="R002",ItemDescription="Ruler 12",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("R01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Dozen")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },
                new Stock {ID=Guid.NewGuid(),ItemCode="R001",ItemDescription="Ruler 6",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("R01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B2")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Dozen")).Select(x=>x.ID).FirstOrDefault(),
                            Price=10,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end ruler

                new Stock {ID=Guid.NewGuid(),ItemCode="S100",ItemDescription="Scissors",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B3")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=6,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end scissor

                new Stock {ID=Guid.NewGuid(),ItemCode="S040",ItemDescription="Scotch Tape",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("T01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=3,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="S041",ItemDescription="Scotch Tape Dispenser",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("T01")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=3,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end tape

                new Stock {ID=Guid.NewGuid(),ItemCode="S101",ItemDescription="Sharpener",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S02")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=4,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end sharpener

                new Stock {ID=Guid.NewGuid(),ItemCode="S010",ItemDescription="Shorthand Book (100 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=80,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=6,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="S011",ItemDescription="Shorthand Book (120 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=80,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=7,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="S012",ItemDescription="Shorthand Book (80 pg)",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S03")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=100,ReoderQty=80,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=6,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//end shorthand book

                new Stock {ID=Guid.NewGuid(),ItemCode="S020",ItemDescription="Stapler No. 28",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S04")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=3,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="S021",ItemDescription="Stapler No. 36",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S04")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Each")).Select(x=>x.ID).FirstOrDefault(),
                            Price=3,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="S022",ItemDescription="Stapler No. 28",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S04")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=9,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },

                new Stock {ID=Guid.NewGuid(),ItemCode="S023",ItemDescription="Stapler No. 36",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("S04")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode=_Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=50,ReoderQty=20,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=9,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },//End Stapler

                new Stock {ID=Guid.NewGuid(),ItemCode="T001",ItemDescription="Thumb Tacks Large",CategoryId=_Categories.Where(x=>x.CategoryCode.Equals("T02")).Select(x=>x.ID).FirstOrDefault(),
                            BinCode = _Bins.Where(x=>x.BinCode.Equals("B4")).Select(x=>x.ID).FirstOrDefault(),
                            ReorderLevelQty=10,ReoderQty=10,UomCode=_Uoms.Where(x=>x.UomDescription.Equals("Box")).Select(x=>x.ID).FirstOrDefault(),
                            Price=7,AddedDate=DateTime.Today.Date,ModifiedDate=DateTime.Today.Date
                },
            };
            foreach (var _stock in _Stocks)
            {
                Uow.Repository<Stock>().Insert(_stock);
            }

            #endregion

            #region " Supplier "

            var _Suppliers = new List<Supplier>
            {
                new Supplier { ID = Guid.NewGuid(), SupplierCode = "ALPA", SupplierName = "ALPHA Office Supplies", ContactName = "Ms Irene Tan", PhoneNo = 64619928, FaxNo = 64612238,
                            Address = "Blk-1128, Ang Mo Kio Industrial Park, #02-1108, Ang Mo Kio Street 62, Singapore 622262", PostalCode = 622262, GstRegNo = "MR-8500440-2",
                            IsSelected = true, AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Supplier { ID = Guid.NewGuid(), SupplierCode = "ALPA", SupplierName = "ALPHA Office Supplies", ContactName = "Ms Irene Tan", PhoneNo = 64619928, FaxNo = 64612238,
                            Address = "Blk-1128, Ang Mo Kio Industrial Park, #02-1108, Ang Mo Kio Street 62, Singapore 622262", PostalCode = 622262, GstRegNo = "MR-8500440-2",
                            IsSelected = true, AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Supplier { ID = Guid.NewGuid(), SupplierCode = "ALPA", SupplierName = "ALPHA Office Supplies", ContactName = "Ms Irene Tan", PhoneNo = 64619928, FaxNo = 64612238,
                            Address = "Blk-1128, Ang Mo Kio Industrial Park, #02-1108, Ang Mo Kio Street 62, Singapore 622262", PostalCode = 622262, GstRegNo = "MR-8500440-2",
                            IsSelected = true, AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Supplier { ID = Guid.NewGuid(), SupplierCode = "ALPA", SupplierName = "ALPHA Office Supplies", ContactName = "Ms Irene Tan", PhoneNo = 64619928, FaxNo = 64612238,
                            Address = "Blk-1128, Ang Mo Kio Industrial Park, #02-1108, Ang Mo Kio Street 62, Singapore 622262", PostalCode = 622262, GstRegNo = "MR-8500440-2",
                            IsSelected = false, AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new Supplier { ID = Guid.NewGuid(), SupplierCode = "ALPA", SupplierName = "ALPHA Office Supplies", ContactName = "Ms Irene Tan", PhoneNo = 64619928, FaxNo = 64612238,
                            Address = "Blk-1128, Ang Mo Kio Industrial Park, #02-1108, Ang Mo Kio Street 62, Singapore 622262", PostalCode = 622262, GstRegNo = "MR-8500440-2",
                            IsSelected = false, AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date }
            };
            foreach (var _Supplier in _Suppliers)
            {
                Uow.Repository<Supplier>().Insert(_Supplier);
            }

            #endregion

            #region " Stock Card "

            var _StockCard = new List<StockCard>
            {
                //new StockCard { ID = Guid.NewGuid(), StockId = _Stocks.Where(x=>x.ItemCode.Equals("H011")).Select(x=>x.ID).FirstOrDefault(), Description ="Supplier-BANE", TransDate =Convert.ToDateTime("02/01/2016"), BalanceQty = 550, Qty = +550, ModifiedDate = DateTime.Today.Date, AddedDate = DateTime.Today.Date },
                //new StockCard { ID = Guid.NewGuid(), StockId = _Stocks.Where(x=>x.ItemCode.Equals("H011")).Select(x=>x.ID).FirstOrDefault(), Description ="English Department", TransDate = Convert.ToDateTime("05/01/2016"), BalanceQty = 530, Qty =-20, ModifiedDate = DateTime.Today.Date, AddedDate = DateTime.Today.Date },
                //new StockCard { ID = Guid.NewGuid(), StockId = _Stocks.Where(x=>x.ItemCode.Equals("H011")).Select(x=>x.ID).FirstOrDefault(), Description ="Administration Deparment", TransDate = Convert.ToDateTime("07/01/2016"), BalanceQty = 500, Qty = -30, ModifiedDate = DateTime.Today.Date, AddedDate = DateTime.Today.Date },

                //new StockCard { ID = Guid.NewGuid(), StockId = _Stocks.Where(x=>x.ItemCode.Equals("P030")).Select(x=>x.ID).FirstOrDefault(), Description ="Supplier-BANE", TransDate = Convert.ToDateTime("02/01/2016"), BalanceQty = 50, Qty = +50, ModifiedDate = DateTime.Today.Date, AddedDate = DateTime.Today.Date },
                //new StockCard { ID = Guid.NewGuid(), StockId = _Stocks.Where(x=>x.ItemCode.Equals("P030")).Select(x=>x.ID).FirstOrDefault(), Description ="Commerce Department", TransDate =Convert.ToDateTime("04/01/2016"), BalanceQty = 40, Qty =-10, ModifiedDate = DateTime.Today.Date, AddedDate = DateTime.Today.Date },
                //new StockCard { ID = Guid.NewGuid(), StockId = _Stocks.Where(x=>x.ItemCode.Equals("P030")).Select(x=>x.ID).FirstOrDefault(), Description ="Computer Science", TransDate =Convert.ToDateTime("09/01/2016"), BalanceQty = 35, Qty = -5, ModifiedDate = DateTime.Today.Date, AddedDate = DateTime.Today.Date }
            };
            foreach (var _stockcard in _StockCard)
            {
                Uow.Repository<StockCard>().Insert(_stockcard);
            }

            #endregion

            #region " Department "

            var _Department = new List<Department>
            {
                new Department { ID = Guid.NewGuid(), DepartmentCode = "ENGL", DepartmentName = "English Dept", ContactName = "Mrs Pamela Kow", PhoneNo = 68742234, FaxNumber = 68921456,
                                AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date},
                new Department { ID = Guid.NewGuid(), DepartmentCode = "CPSC", DepartmentName = "Computer Science", ContactName ="Mr Wee Kian Fatt", PhoneNo = 68901235, FaxNumber = 68921257,
                                AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date},
                new Department { ID = Guid.NewGuid(), DepartmentCode = "COMM", DepartmentName = "Commerce Dept", ContactName = "Mr Hohd. Azman", PhoneNo = 68741284, FaxNumber = 68921256,
                                AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date},
                new Department { ID = Guid.NewGuid(), DepartmentCode = "REGR", DepartmentName = "Registrar Dept", ContactName = "Ms Helen Ho", PhoneNo = 68901266, FaxNumber = 68921465,
                                AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date},
                new Department { ID = Guid.NewGuid(), DepartmentCode = "ZOOL", DepartmentName = "Zoology Dept", ContactName = "Mr. Peter Tan Ah Meng", PhoneNo = 68901266, FaxNumber = 68921256,
                                AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date},
            };
            foreach (var _department in _Department)
            {
                Uow.Repository<Department>().Insert(_department);
            }

            #endregion

            #region " User Roles "

            var _UserRoles = new List<UserRoles>
            {
                new UserRoles { ID = Guid.NewGuid(), Name = "Department Head", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                //new UserRoles { ID = Guid.NewGuid(), Name = "Department Representative", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UserRoles { ID = Guid.NewGuid(), Name = "Employee", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UserRoles { ID = Guid.NewGuid(), Name = "Store Clerk", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UserRoles { ID = Guid.NewGuid(), Name = "Store Supervisor", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date },
                new UserRoles { ID = Guid.NewGuid(), Name = "Store Manager", AddedDate = DateTime.Now.Date, ModifiedDate = DateTime.Now.Date }
            };
            foreach (var _UserRole in _UserRoles)
            {
                Uow.Repository<UserRoles>().Insert(_UserRole);
            }

            #endregion

            #region " Employees "

            var _Employees = new List<Employee>
            {
                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046801", EmployeeName = "Esther", EmplpyeeEmail = "aungthuhein009@gmail.com", Password = "123123",
                             UserRoleId = _UserRoles.Where(x => x.Name.Equals("Department Head")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ENGL")).Select(x => x.ID).FirstOrDefault(),

                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046802", EmployeeName = "Shoun Lee", EmplpyeeEmail = "shounlee@gmail.com", Password = "112233",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ENGL")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = true, FromDate = DateTime.Now.Date, ToDate = Convert.ToDateTime("31/01/2017").Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046803", EmployeeName = "Moe Pyie Sone", EmplpyeeEmail = "mrmoepyie92@gmail.com", Password = "0986123",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ENGL")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046804", EmployeeName = "Ye Kyaw Paing", EmplpyeeEmail = "wiz.ash.1331@gmail.com", Password = "1234567",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ENGL")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                //end Eng Dept

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046805", EmployeeName = "Aung Khant Phyo", EmplpyeeEmail = "aungkhantphyo@gmail.com", Password = "342516",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Department Head")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("CPSC")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046806", EmployeeName = "Chan Nyein Aung", EmplpyeeEmail = "nelvischen@gmail.com", Password = "12345",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("CPSC")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = true, FromDate = DateTime.Now.Date, ToDate = Convert.ToDateTime("31/01/2017").Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046807", EmployeeName = "Zwe Htet Naing", EmplpyeeEmail = "zwehtetnaing@gmail.com", Password = "443322",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("CPSC")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046808", EmployeeName = "Zoe Wee", EmplpyeeEmail = "zoewee@gmail.com", Password = "221133",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("CPSC")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                //end CPSC Dept

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046809", EmployeeName = "Xu Ram", EmplpyeeEmail = "xuram@gmail.com", Password = "123400",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Department Head")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("COMM")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046810", EmployeeName = "Aung Thu Hein", EmplpyeeEmail = "agthuhein1991@gmail.com", Password = "12345",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("COMM")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = true, FromDate = DateTime.Now.Date, ToDate = Convert.ToDateTime("31/01/2017").Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046811", EmployeeName = "May Lay", EmplpyeeEmail = "maylay1994@gmail.com", Password = "443322",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("COMM")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046812", EmployeeName = "Kyi Lin Tun", EmplpyeeEmail = "kyilintun@gmail.com", Password = "221133",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("COMM")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },
                //end COMM Dept

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046813", EmployeeName = "Than Htun Win", EmplpyeeEmail = "thanhtutwin@gmail.com", Password = "342516",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Department Head")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("REGR")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046814", EmployeeName = "Kaung Myat Linn", EmplpyeeEmail = "kaungmyatlinn@gmail.com", Password = "12345",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("REGR")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = true, FromDate = DateTime.Now.Date, ToDate = Convert.ToDateTime("31/01/2017").Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046815", EmployeeName = "Aung Ye Kaung", EmplpyeeEmail = "aungyekaung@gmail.com", Password = "443322",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("REGR")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046816", EmployeeName = "Hein Htet Aung", EmplpyeeEmail = "heinhtetaung@gmail.com", Password = "221133",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("REGR")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                //end REGR dept
                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046817", EmployeeName = "Zaw Myo Htet", EmplpyeeEmail = "zawmyohtet@gmail.com", Password = "342516",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Department Head")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ZOOL")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046818", EmployeeName = "Ei Ei Mon", EmplpyeeEmail = "eieimon@gmail.com", Password = "12345",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ZOOL")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = true, FromDate = DateTime.Now.Date, ToDate = Convert.ToDateTime("31/01/2017").Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046819", EmployeeName = "Wai Yan Oo", EmplpyeeEmail = "waiyanoo@gmail.com", Password = "443322",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ZOOL")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now.Date, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now.Date,ModifiedDate=DateTime.Now.Date  },

                new Employee { ID = Guid.NewGuid(), EmployeeNumber = "E0046820", EmployeeName = "Ei Yadanar Soe", EmplpyeeEmail = "eiyadanarsoe@gmail.com", Password = "221133",
                            UserRoleId = _UserRoles.Where(x => x.Name.Equals("Employee")).Select(x => x.ID).FirstOrDefault(),
                            DepartmentId = _Department.Where(x => x.DepartmentCode.Equals("ZOOL")).Select(x => x.ID).FirstOrDefault(),
                            IsDelegateAuthority = false, FromDate = DateTime.Now, ToDate = DateTime.Now.Date,AddedDate=DateTime.Now,ModifiedDate=DateTime.Now.Date }
                //end ZOOL Dept

                         

            };
            foreach (var _Employee in _Employees)
            {
                Uow.Repository<Employee>().Insert(_Employee);
            }

            #endregion

            #region "RequisitionHeader"
            var _RequisitionHeaders = new List<RequititionHeader>
            {
                new RequititionHeader
                {
                    ID = Guid.NewGuid(),EmployeeId = _Employees.Where(x=>x.EmployeeNumber.Equals("E0046805")).Select(x=>x.ID).FirstOrDefault(),
                    RequestionCode = "DDS/111/99",TransDate = Convert.ToDateTime("10/12/2000"),Status = "Pending",AddedDate = DateTime.Today,ModifiedDate = DateTime.Today
                },
                new RequititionHeader
                {
                    ID = Guid.NewGuid(),EmployeeId = _Employees.Where(x=>x.EmployeeNumber.Equals("E0046818")).Select(x=>x.ID).FirstOrDefault(),
                    RequestionCode = "DDS/111/10",TransDate = Convert.ToDateTime("11/12/2000"),Status = "Approved",AddedDate = DateTime.Today,ModifiedDate = DateTime.Today
                },
                new RequititionHeader
                {
                    ID = Guid.NewGuid(),EmployeeId= _Employees.Where(x=>x.EmployeeNumber.Equals("E0046819")).Select(x=>x.ID).FirstOrDefault(),
                    RequestionCode = "DDS/111/11",TransDate = Convert.ToDateTime("13/12/2000"),Status = "Pending",AddedDate = DateTime.Today,ModifiedDate = DateTime.Today
                },
                new RequititionHeader
                {
                    ID = Guid.NewGuid(),EmployeeId = _Employees.Where(x=>x.EmployeeNumber.Equals("E0046817")).Select(x=>x.ID).FirstOrDefault(),
                    RequestionCode = "DDS/111/14",TransDate = Convert.ToDateTime("11/12/2000"),Status = "Rejected",AddedDate = DateTime.Today,ModifiedDate = DateTime.Today
                },

            };
            foreach (var _requisitionHeader in _RequisitionHeaders)
            {
                Uow.Repository<RequititionHeader>().Insert(_requisitionHeader);
            }


            #endregion

            #region RequisitionDetails
            var _RequisitionDetails = new List<RequisitionDetail>
            {
                new RequisitionDetail
                {
                    ID = Guid.NewGuid(),RequisitionHeaderId =_RequisitionHeaders.Where(x=>x.RequestionCode.Equals("DDS/111/99")).Select(x=>x.ID).FirstOrDefault(),
                    StockId = _Stocks.Where(x=>x.ItemCode.Equals("C001")).Select(x=>x.ID).FirstOrDefault(),OutstandingQty = -2,RequestedQty = 10,RetrieveQty = 0,
                    OutstandingStatus = false,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today
                },
                new RequisitionDetail
                {
                    ID = Guid.NewGuid(),RequisitionHeaderId =_RequisitionHeaders.Where(x=>x.RequestionCode.Equals("DDS/111/99")).Select(x=>x.ID).FirstOrDefault(),
                    StockId = _Stocks.Where(x=>x.ItemCode.Equals("P001")).Select(x=>x.ID).FirstOrDefault(),OutstandingQty = 0,RequestedQty = 15,RetrieveQty = 15,
                    OutstandingStatus = true,ModifiedDate = DateTime.Today,AddedDate = DateTime.Today
                }
            };
            foreach (var _requsitionDetail in _RequisitionDetails)
            {
                Uow.Repository<RequisitionDetail>().Insert(_requsitionDetail);
            }



            #endregion

            base.Seed(context);
        }
       

    }
}