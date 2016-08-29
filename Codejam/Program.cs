using System;
using System.Collections.Generic;
using System.Text;

namespace Codejam
{
    class RGB
    {
        int GetLeast(string[] picture)
        {
            int strokesToReturn = 0;
            int pictureLength = picture.Length;
            int lengthOfOneRow = picture[0].Length;
            int count = 0;
            char[][] pictureMatrix = new char[pictureLength][];

            for (int loopRow=0;loopRow<pictureLength;loopRow++)
            {
                pictureMatrix[loopRow] = picture[loopRow].ToCharArray();
            }
           
            for(int i=0; i<pictureLength;i++)
            {
                for(int j=0 ; j<lengthOfOneRow ; j++)
                {
                    if (pictureMatrix[i][j].Equals('.'))
                    {
                        continue;
                    }
                    else if (pictureMatrix[i][j].Equals('G'))
                    {
                        int loopVarToIncrement = i;
                        
                        while (loopVarToIncrement < pictureLength && pictureMatrix[loopVarToIncrement][j] == 'B' | pictureMatrix[loopVarToIncrement][j] == 'G')
                        {
                            if (pictureMatrix[loopVarToIncrement][j] == 'G')
                            {
                                pictureMatrix[loopVarToIncrement][j] = 'R';
                            }
                            else if (pictureMatrix[loopVarToIncrement][j] == 'B')
                            {
                                pictureMatrix[loopVarToIncrement][j] = '.';
                            }

                            if (loopVarToIncrement < pictureLength)
                            {
                                loopVarToIncrement++;
                            }
                            else
                                break;
                        }
                        strokesToReturn++;

                        loopVarToIncrement = j;

                        while (loopVarToIncrement < lengthOfOneRow && pictureMatrix[i][loopVarToIncrement] == 'R' | pictureMatrix[i][loopVarToIncrement] == 'G')
                        {
                            if (pictureMatrix[i][loopVarToIncrement] == 'G')
                            {
                                pictureMatrix[i][loopVarToIncrement] = 'B';
                            }
                            else if (pictureMatrix[i][loopVarToIncrement] == 'R')
                            {
                                pictureMatrix[i][loopVarToIncrement] = '.';
                            }

                            if (loopVarToIncrement < lengthOfOneRow)
                            {
                                loopVarToIncrement++;
                            }
                            else
                                break;
                        }
                        strokesToReturn++;

                    }
                    else if (pictureMatrix[i][j].Equals('B'))
                    {
                        int loopVarToIncrement = i;
                        int loopVarToDecrement = i;


                        while (loopVarToIncrement < pictureLength && pictureMatrix[loopVarToIncrement][j] == 'B' | pictureMatrix[loopVarToIncrement][j] == 'G')
                        {
                            if (pictureMatrix[loopVarToIncrement][j] == 'B')
                            {
                                pictureMatrix[loopVarToIncrement][j] = '.';
                            }
                            else if (pictureMatrix[loopVarToIncrement][j] == 'G')
                            {
                                pictureMatrix[loopVarToIncrement][j] = 'R';
                            }

                            if (loopVarToIncrement < pictureLength)
                            {
                                loopVarToIncrement++;
                            }
                            else
                                break;

                        }
                        strokesToReturn++;
                    }
                    else if (pictureMatrix[i][j].Equals('R'))
                    {
                        int loopVarToIncrement = j;

                        while (loopVarToIncrement < lengthOfOneRow && pictureMatrix[i][loopVarToIncrement] == 'R' | pictureMatrix[i][loopVarToIncrement] == 'G')
                        {
                            if (pictureMatrix[i][loopVarToIncrement] == 'R')
                            {
                                pictureMatrix[i][loopVarToIncrement] = '.';
                            }
                            else if (pictureMatrix[i][loopVarToIncrement] == 'G')
                            {
                                pictureMatrix[i][loopVarToIncrement] = 'B';
                            }

                            if (loopVarToIncrement < lengthOfOneRow)
                            {
                                loopVarToIncrement++;
                            }
                            else
                                break;
                        }
                        strokesToReturn++;
                    }
                }
            }
           
           
                    return strokesToReturn+count;
        }

        

        #region Testing code Do not change
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            RGB rgbSolver = new RGB();
            do
            {
                string[] picture = input.Split(',');
                Console.WriteLine(rgbSolver.GetLeast(picture));
                input = Console.ReadLine();
            } while (input != "-1");
        }
        #endregion
    }
}

