using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IN2011_PROJECT.Business
{
    public class Runner : Role
    {
        #region Data Member
        //encapsulation
        private decimal tips, rate;
        private int NumberOfShifts;
        #endregion

        #region Property Methods
        public decimal getTips
        {
            get { return tips; }
            set { tips = value; }
        }

        public decimal getRate
        {