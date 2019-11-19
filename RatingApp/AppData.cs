using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RatingApp
{
    class AppData
    {
        protected int totalVote;
        protected int fiveStarVote;
        protected int fourStarVote;
        protected int threeStarVote;
        protected int twoStarVote;
        protected int oneStarVote;

        public int TotalVote
        {
            get
            {
                return totalVote;
            }
            set
            {
                if (totalVote != value)
                {
                    totalVote = value;
                }
            }
        }

        public int FiveStarVote
        {
            get
            {
                return fiveStarVote;
            }
            set
            {
                if (fiveStarVote != value)
                {
                    fiveStarVote = value;
                }
            }
        }
        public int FourStarVote
        {
            get
            {
                return fourStarVote;
            }
            set
            {
                if (fourStarVote != value)
                {
                    fourStarVote = value;
                }
            }
        }
        public int ThreeStarVote
        {
            get
            {
                return threeStarVote;
            }
            set
            {
                if (threeStarVote != value)
                {
                    threeStarVote = value;
                }
            }
        }
        public int TwoStarVote
        {
            get
            {
                return twoStarVote;
            }
            set
            {
                if (twoStarVote != value)
                {
                    twoStarVote = value;
                }
            }
        }
        public int OneStarVote
        {
            get
            {
                return oneStarVote;
            }
            set
            {
                if (oneStarVote != value)
                {
                    oneStarVote = value;
                }
            }
        }

        public AppData()
        {
            this.totalVote = 0;
            this.fiveStarVote = 0;
            this.fourStarVote = 0;
            this.totalVote = 0;
            this.twoStarVote = 0;
            this.oneStarVote = 0;
        }
    }
}
