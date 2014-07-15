using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        int frame_cnt = 0;
        int[] frame_score = new int[12];
        int[] frame_status = new int[12];
        int prev = -1;
        int score = 0;
        public void Roll(int pins)
        {
            manage_score(pins);
            //throw new NotImplementedException();
        }

        public int GetScore()
        {
            int final_score = score;
            //Console.Write("hi");
            for (int i = 0; i < frame_cnt; i++)
                Console.Write("{0}\t", frame_score[i]);
            for (int i = 0; i < frame_cnt; i++)
            {
                if (i < 9)
                {
                    if (frame_status[i] == 1)
                        final_score = final_score + frame_score[i + 1];
                    else if (frame_status[i] == 2)
                        final_score = final_score + frame_score[i + 1] + frame_score[i + 2];
                }
            }

            return final_score;
            //throw new NotImplementedException();
        }

        public void manage_score(int pins)
        {

            score = score + pins;
            if (prev == -1)
            {
                if (pins == 10)
                {
                    frame_status[frame_cnt] = 2;
                    frame_score[frame_cnt] = pins;
                    frame_cnt = frame_cnt + 1;
                }
                else
                {
                    prev = pins;
                }
            }
            else
            {
                frame_score[frame_cnt] = prev + pins;
                prev = -1;
                if (frame_score[frame_cnt] == 10)
                    frame_status[frame_cnt] = 1;
                else
                    frame_status[frame_cnt] = -1;
                frame_cnt += 1;
            }

        }

    }
}
