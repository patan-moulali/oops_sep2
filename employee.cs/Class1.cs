﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general_lib
{
    public class product
    {
        private int _prodid;

        public int ProductId
        {
            get { return _prodid; }
            set { _prodid = value; }
        }

        private string _prodname;

        public string ProductName
        {
            get { return _prodname; }
            set { _prodname = value; }
        }

        private int _qtysold;

        public int QtySold
        {
            get { return _qtysold; }
            set { _qtysold = value; }
        }

        private int _unitp;

        public int UnitPrice
        {
            get { return _unitp; }
            set { _unitp = value; }
        }
        private string _unitofm;

        public string UnitofMeasure
        {
            get { return _unitofm; }
            set { _unitofm = value; }
        }

        private int _qtyhand;

        public int QtyinHand
        {
            get { return _qtyhand; }
            set { _qtyhand = value; }
        }

        private int _reorderlevl;

        public int ReorderLvl
        {
            get { return _reorderlevl; }
            set { _reorderlevl = value; }
        }


        public void Addproduct()
        {
            _prodid = 3;
            _prodname = "soda";
            _qtysold = 3;
            _unitp = 100;
            _unitofm = "litres";
            _qtyhand = 6;
            _reorderlevl = 7;




        }




    }
}