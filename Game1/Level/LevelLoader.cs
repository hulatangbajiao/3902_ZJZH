using Game1.Interfaces;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Xml;


namespace Game1.Level
{
    public class LevelLoader
    {
        private XmlDocument LevelXml;


        public LevelLoader()
        {
            LevelXml = new XmlDocument();

            LevelXml.Load("Level1.xml");


        }

        public List<IRoom> LoadRooms(ILink link)
        {
            List<IRoom> rooms = new List<IRoom>();
            XmlNode root = LevelXml.FirstChild.NextSibling;

            foreach (XmlNode roomNode in root)
            {
                IRoom room = new Room();
                room.Link = link;

                XmlNode enemiesNode = roomNode.FirstChild;
                if (enemiesNode.Attributes["total"].Value != "0")
                {
                    foreach (XmlNode enemyNode in enemiesNode)
                    {
                        string enemyName = enemyNode["ObjectType"].InnerText;
                        float columnNum = float.Parse(enemyNode["ColumnNum"].InnerText);
                        float rowNum = float.Parse(enemyNode["RowNum"].InnerText);
                        Vector2 position = new Vector2(columnNum * 48, rowNum * 48);
                        switch (enemyName)
                        {
                            case "Aquamentus":
                                room.Enemies.Add(new Aquamentus((1,0),position));
                                break;

                            case "BlueBat":
                                room.Enemies.Add(new BlueBat((1,0), position));
                                break;
                            case "BlueGoriya":
                                room.Enemies.Add(new BlueGoriya((1,0), position));
                                break;
                            case "RedGoriya":
                                room.Enemies.Add(new RedGoriya((1,0), position));
                                break;
                            case "RedBat":
                                room.Enemies.Add(new RedBat((1,0), position));
                                break;
                            case "Oct":
                                room.Enemies.Add(new Oct((1,0), position));
                                break;
                            case "BlueOct":
                                room.Enemies.Add(new BlueOct((1,0), position));
                                break;
                            case "BlueM":
                                room.Enemies.Add(new BlueM((1,0), position));
                                break;



                        }
                    }
                }
                XmlNode itemsNode = enemiesNode.NextSibling;
                if (itemsNode.Attributes["total"].Value != "0")
                {
                    foreach (XmlNode itemNode in itemsNode)
                    {
                        string itemName = itemNode["ObjectType"].InnerText;
                        float columnNum = float.Parse(itemNode["ColumnNum"].InnerText);
                        float rowNum = float.Parse(itemNode["RowNum"].InnerText);
                        Vector2 position = new Vector2(columnNum * 48, rowNum * 48);
                        switch (itemName)
                        {
                            case "Arrow":
                                room.ReceivedItems.Add(new ItemArrow(position));
                                break;
                            case "Bomerang":
                                room.ReceivedItems.Add(new ItemBoomer(position));
                                break;
                            case "Bomb":
                                room.ReceivedItems.Add(new ItemBomb(position));
                                break;

                            case "Bow":
                                room.ReceivedItems.Add(new ItemBow(position));
                                break;
                            case "Clock":
                                room.ObtainedItems.Add(new ItemClock(position));
                                break;
                            case "Compass":
                                room.ReceivedItems.Add(new ItemCompass(position));
                                break;

                            case "Fairy":
                                room.ObtainedItems.Add(new ItemFairy(position));
                                break;
                            case "Rupee":
                                room.ObtainedItems.Add(new ItemRupee(position));
                                break;

                            case "Heart":
                                room.ObtainedItems.Add(new ItemHeart(position));
                                break;
                            case "HeartContainer":
                                room.ObtainedItems.Add(new ItemHeartContainer(position));
                                break;
                            case "Key":
                                room.ObtainedItems.Add(new ItemKey(position));
                                break;



                            case "Triforce":
                                room.ReceivedItems.Add(new ItemTriforce(position));
                                break;

                        }

                    }
                }
                XmlNode blocksNode = itemsNode.NextSibling;
                if (blocksNode.Attributes["total"].Value != "0")
                {
                    foreach (XmlNode blockNode in blocksNode)
                    {
                        string BlockName = blockNode["ObjectType"].InnerText;
                        float columnNum = float.Parse(blockNode["ColumnNum"].InnerText);
                        float rowNum = float.Parse(blockNode["RowNum"].InnerText);
                        Vector2 position = new Vector2(columnNum * 50, rowNum * 50);
                        switch (BlockName)
                        {
                            case "NoneMoveableBlock":
                                //room.Block.Add(new Block(false, new Rectangle((int)position.X, (int)position.Y, 48, 48), MapAndHUDSpriteFactory.Instance.CreateSignleBlock()));
                                room.Block.Add(new UnpassableBlock(position));
                                break;

                            case "River":
                                room.Block.Add(new UnpassableBlock(position));// need a new block class
                                break;
                        }
                    }
                }
                rooms.Add(room);
            }
            int index = 0;
            foreach (XmlNode roomNode in root)
            {
                XmlNode northNode = roomNode.FirstChild.NextSibling.NextSibling.NextSibling;
                if (northNode.InnerText != "")
                {
                    rooms[index].North = rooms[int.Parse(northNode.InnerText) - 1];
                    rooms[index].HasNorth = true;
                }
                XmlNode eastNode = northNode.NextSibling;
                if (eastNode.InnerText != "")
                {
                    rooms[index].East = rooms[int.Parse(eastNode.InnerText) - 1];
                    rooms[index].HasEast = true;
                }
                XmlNode southNode = eastNode.NextSibling;
                if (southNode.InnerText != "")
                {
                    rooms[index].South = rooms[int.Parse(southNode.InnerText) - 1];
                    rooms[index].HasSouth = true;
                }
                XmlNode westNode = southNode.NextSibling;
                if (westNode.InnerText != "")
                {
                    rooms[index].West = rooms[int.Parse(westNode.InnerText) - 1];
                    rooms[index].HasWest = true;
                }
                XmlNode otherNode = westNode.NextSibling;
                if (otherNode.InnerText != "")
                {
                    rooms[index].Other = rooms[int.Parse(otherNode.InnerText) - 1];
                    rooms[index].HasOther = true;
                }
                index += 1;
            }

            return rooms;
        }


    }
}
