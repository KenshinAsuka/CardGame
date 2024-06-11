using System.Drawing;

namespace CardGame.Constants
{
    public class Array
    {
        public static readonly string[] Cards = { "2@", "2#", "2^", "2*", "3@", "3#", "3^", "3*", "4@", "4#", "4^", "4*", "5@", "5#", "5^", "5*",
                                                  "6@", "6#", "6^", "6*", "7@", "7#", "7^", "7*", "8@", "8#", "8^", "8*", "9@", "9#", "9^", "9*",
                                                  "10@", "10#", "10^", "10*", "J@", "J#", "J^", "J*", "Q@", "Q#", "Q^", "Q*", "K@", "K#", "K^", "K*",
                                                  "A@", "A#", "A^", "A*"};

        public Array() { }

        public string[] GetRandomCards()
        {
            Random rng = new Random();

            string[] newCards = Cards;

            rng.Shuffle(newCards);

            return newCards;
        }

        public string[] GetOriginalCards()
        { 
            return Cards.OrderBy(i => i).ToArray(); 
        }

        public List<string> SplitChar(char[] text)
        {
            List<string> result = new List<string>();
            int n = text.Length;

            if (n == 0)
                return result;

            if(n == 2)
            {
                result.Add(text[0].ToString());
                result.Add(text[1].ToString());
            }
            else if(n == 3)
            {
                result.Add(text[0].ToString());
                result.Add(text[1].ToString());
                result.Add(text[2].ToString());
            }

            return result;
        }

        public int CalculatePoints(List<string> sArr)
        {
            int[] p2 = [0, 0, 0, 0];
            int[] p3 = [0, 0, 0, 0];
            int[] p4 = [0, 0, 0, 0];
            int[] p5 = [0, 0, 0, 0];
            int[] p6 = [0, 0, 0, 0];
            int[] p7 = [0, 0, 0, 0];
            int[] p8 = [0, 0, 0, 0];
            int[] p9 = [0, 0, 0, 0];
            int[] p10 = [0, 0, 0, 0];
            int[] pj = [0, 0, 0, 0];
            int[] pq = [0, 0, 0, 0];
            int[] pk = [0, 0, 0, 0];
            int[] pa = [0, 0, 0, 0];
            int totalPoints = 0;
            string point = "";
            string shape = "";
            foreach (string s in sArr)
            {
                var charArr = SplitChar(s.ToCharArray());

                if (charArr[0] == "1")
                {
                    point = charArr[0].ToString() + charArr[1].ToString();
                    shape = charArr[2].ToString();
                }
                else
                {
                    point = charArr[0].ToString();
                    shape = charArr[1].ToString();
                }

                

                if (int.TryParse(point, out int i))
                {
                    if (i == 2)
                    {
                        switch (shape)
                        {
                            case "*":
                                p2[0] = 1;
                                break;
                            case "^":
                                p2[1] = 2;
                                break;
                            case "#":
                                p2[2] = 3;
                                break;
                            case "@":
                                p2[3] = 4;
                                break;

                        }
                    }
                    else if (i == 3)
                    {
                        switch (shape)
                        {
                            case "*":
                                p3[0] = 1;
                                break;
                            case "^":
                                p3[1] = 2;
                                break;
                            case "#":
                                p3[2] = 3;
                                break;
                            case "@":
                                p3[3] = 4;
                                break;

                        }
                    }
                    else if (i == 4)
                    {
                        switch (shape)
                        {
                            case "*":
                                p4[0] = 1;
                                break;
                            case "^":
                                p4[1] = 2;
                                break;
                            case "#":
                                p4[2] = 3;
                                break;
                            case "@":
                                p4[3] = 4;
                                break;

                        }
                    }
                    else if (i == 5)
                    {
                        switch (shape)
                        {
                            case "*":
                                p5[0] = 1;
                                break;
                            case "^":
                                p5[1] = 2;
                                break;
                            case "#":
                                p5[2] = 3;
                                break;
                            case "@":
                                p5[3] = 4;
                                break;

                        }
                    }
                    else if (i == 6)
                    {
                        switch (shape)
                        {
                            case "*":
                                p6[0] = 1;
                                break;
                            case "^":
                                p6[1] = 2;
                                break;
                            case "#":
                                p6[2] = 3;
                                break;
                            case "@":
                                p6[3] = 4;
                                break;

                        }
                    }
                    else if (i == 7)
                    {
                        switch (shape)
                        {
                            case "*":
                                p7[0] = 1;
                                break;
                            case "^":
                                p7[1] = 2;
                                break;
                            case "#":
                                p7[2] = 3;
                                break;
                            case "@":
                                p7[3] = 4;
                                break;

                        }
                    }
                    else if (i == 8)
                    {
                        switch (shape)
                        {
                            case "*":
                                p8[0] = 1;
                                break;
                            case "^":
                                p8[1] = 2;
                                break;
                            case "#":
                                p8[2] = 3;
                                break;
                            case "@":
                                p8[3] = 4;
                                break;

                        }
                    }
                    else if (i == 9)
                    {
                        switch (shape)
                        {
                            case "*":
                                p9[0] = 1;
                                break;
                            case "^":
                                p9[1] = 2;
                                break;
                            case "#":
                                p9[2] = 3;
                                break;
                            case "@":
                                p9[3] = 4;
                                break;

                        }
                    }
                    else if (i == 10)
                    {
                        switch (shape)
                        {
                            case "*":
                                p10[0] = 1;
                                break;
                            case "^":
                                p10[1] = 2;
                                break;
                            case "#":
                                p10[2] = 3;
                                break;
                            case "@":
                                p10[3] = 4;
                                break;

                        }
                    }
                }
                else
                {

                    if (point == "J")
                    {
                        switch (shape)
                        {
                            case "*":
                                pj[0] = 1;
                                break;
                            case "^":
                                pj[1] = 2;
                                break;
                            case "#":
                                pj[2] = 3;
                                break;
                            case "@":
                                pj[3] = 4;
                                break;

                        }
                    }
                    else if (point == "Q")
                    {
                        switch (shape)
                        {
                            case "*":
                                pq[0] = 1;
                                break;
                            case "^":
                                pq[1] = 2;
                                break;
                            case "#":
                                pq[2] = 3;
                                break;
                            case "@":
                                pq[3] = 4;
                                break;

                        }
                    }
                    else if (point == "K")
                    {
                        switch (shape)
                        {
                            case "*":
                                pk[0] = 1;
                                break;
                            case "^":
                                pk[1] = 2;
                                break;
                            case "#":
                                pk[2] = 3;
                                break;
                            case "@":
                                pk[3] = 4;
                                break;

                        }
                    }
                    else if (point == "A")
                    {
                        switch (shape)
                        {
                            case "*":
                                pa[0] = 1;
                                break;
                            case "^":
                                pa[1] = 2;
                                break;
                            case "#":
                                pa[2] = 3;
                                break;
                            case "@":
                                pa[3] = 4;
                                break;

                        }
                    }

                }
            }

            int temp = 0;

            if (p2.Length > 1)
            {
                foreach (var p in p2)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 2);
                temp = 0;
            }

            if (p3.Length > 1)
            {
                foreach (var p in p3)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 3);
                temp = 0;
            }

            if (p4.Length > 1)
            {
                foreach (var p in p4)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 4);
                temp = 0;
            }

            if (p5.Length > 1)
            {
                foreach (var p in p5)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 5);
                temp = 0;
            }

            if (p6.Length > 1)
            {
                foreach (var p in p6)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 6);
                temp = 0;
            }

            if (p7.Length > 1)
            {
                foreach (var p in p7)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 7);
                temp = 0;
            }

            if (p8.Length > 1)
            {
                foreach (var p in p8)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 8);
                temp = 0;
            }

            if (p9.Length > 1)
            {
                foreach (var p in p9)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 9);
                temp = 0;
            }

            if (p10.Length > 1)
            {
                foreach (var p in p10)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 10);
                temp = 0;
            }

            if (pj.Length > 1)
            {
                foreach (var p in pj)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 11);
                temp = 0;
            }

            if (pq.Length > 1)
            {
                foreach (var p in pq)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 12);
                temp = 0;
            }

            if (pk.Length > 1)
            {
                foreach (var p in pk)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 13);
                temp = 0;
            }

            if (pa.Length > 1)
            {
                foreach (var p in pa)
                {
                    temp = temp + p;
                }

                totalPoints = totalPoints + (temp * 14);
                temp = 0;
            }

            return totalPoints;
        }

        public string GetWinner(int p1, int p2, int p3, int p4)
        {
            if(p1 > p2)
            {
                if (p1 > p3)
                {
                    if (p1 > p4)
                    {
                        return "Player 1 wins";
                    }
                    else
                    {
                        return "Player 4 wins";
                    }
                }
                else
                {
                    if (p3 > p4)
                    {
                        return "Player 3 wins";
                    }
                    else
                    {
                        return "Player 4 wins";
                    }
                }
            }
            else
            {
                if(p2 > p3)
                {
                    if (p2 > p3)
                    {
                        return "Player 2 wins";
                    }
                    else
                    {
                        return "Player 3 wins";
                    }
                }
                else
                {
                    if (p3 > p4)
                    {
                        return "Player 3 wins";
                    }
                    else
                    {
                        return "Player 4 wins";
                    }
                }
            }
        }
    }
}
