using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Project1
{
    public class INFO : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        #region get set
        public String bas_empno { get; set; }
        public String bas_resno1 { get; set; }
        public String bas_resno2 { get; set; }
        public String bas_name { get; set; }
        public String bas_cname { get; set; }
        public String bas_ename { get; set; }
        public String bas_fix { get; set; }
        public String bas_zip { get; set; }
        public String bas_addr { get; set; }
        public String bas_residence { get; set; }
        public String bas_hdpno { get; set; }
        public String bas_telno { get; set; }
        public String bas_email { get; set; }
        public String bas_mil_sta { get; set; }
        public String bas_mil_mil { get; set; }
        public String bas_mil_rnk { get; set; }
        public String bas_mar { get; set; }
        public String bas_acc_bank1 { get; set; }
        public String bas_acc_name1 { get; set; }
        public String bas_acc_no1 { get; set; }
        public String bas_acc_bank2 { get; set; }
        public String bas_acc_name2 { get; set; }
        public String bas_acc_no2 { get; set; }
        public String bas_cont { get; set; }
        public String bas_intern { get; set; }
        public String bas_intern_no { get; set; }
        public String bas_emp_sdate { get; set; }
        public String bas_emp_edate { get; set; }
        public String bas_entdate { get; set; }
        public String bas_resdate { get; set; }
        public String bas_levdate { get; set; }
        public String bas_reidate { get; set; }
        public String bas_wsta { get; set; }
        public String bas_sts { get; set; }
        public String bas_pos { get; set; }
        public String bas_dut { get; set; }
        public String bas_dept { get; set; }
        public String bas_rmk { get; set; }
        public String bas_pos_dt { get; set; }
        public String bas_dut_dt { get; set; }
        public String bas_dept_dt { get; set; }
        public String bas_intern_dt { get; set; }
        #endregion
        public INFO(string empno, string resno1, string resno2, string name,
            string cname, string ename, string fix, string zip, string addr,
            string residence, string hdpno, string telno, string email, string mil_sta,
            string mil_mil, string mil_rnk, string mar, string acc_bank1, string acc_name1, string acc_no1,
            string acc_bank2, string acc_name2, string acc_no2, string cont, string intern, string intern_no,
            string emp_sdate, string emp_edate, string entdate, string resdate, string levdate, string reidate,
            string wsta, string sts, string pos, string dut, string dept, string rmk, string pos_dt, string dut_dt,
            string dept_dt, string intern_dt)
        {
            this.bas_empno = empno;
            this.bas_resno1 = resno1;
            this.bas_resno2 = resno2;
            this.bas_name = name;
            this.bas_cname = cname;
            this.bas_ename = ename;
            this.bas_fix = fix;
            this.bas_zip = zip;
            this.bas_addr = addr;
            this.bas_residence = residence;
            this.bas_hdpno = hdpno;
            this.bas_telno = telno;
            this.bas_email = email;
            this.bas_mil_sta = mil_sta;
            this.bas_mil_mil = mil_mil;
            this.bas_mil_rnk = mil_rnk;
            this.bas_mar = mar;
            this.bas_acc_bank1 = acc_bank1;
            this.bas_acc_name1 = acc_name1;
            this.bas_acc_no1 = acc_no1;
            this.bas_acc_bank2 = acc_bank2;
            this.bas_acc_name2 = acc_name2;
            this.bas_acc_no2 = acc_no2;
            this.bas_cont = cont;
            this.bas_intern = intern;
            this.bas_intern_no = intern_no;
            this.bas_emp_sdate = emp_sdate;
            this.bas_emp_edate = emp_edate;
            this.bas_entdate = entdate;
            this.bas_resdate = resdate;
            this.bas_levdate = levdate;
            this.bas_reidate = reidate;
            this.bas_wsta = wsta;
            this.bas_sts = sts;
            this.bas_pos = pos;
            this.bas_dut = dut;
            this.bas_dept = dept;
            this.bas_rmk = rmk;
            this.bas_pos_dt = pos_dt;
            this.bas_dut_dt = dut_dt;
            this.bas_dept_dt = dept_dt;
            this.bas_intern_dt = intern_dt;
        }

        private void NotifiPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public class SortableBindingList<T> : BindingList<T> where T : class
        {
            private bool _isSorted;
            private ListSortDirection _sortDirection = ListSortDirection.Ascending;
            private PropertyDescriptor _sortProperty;

            public SortableBindingList(IList<T> list) : base(list)
            {

            }

            public SortableBindingList()
            {

            }

            protected override bool SupportsSortingCore { get { return true; } }
            protected override bool IsSortedCore { get { return _isSorted; } }
            protected override ListSortDirection SortDirectionCore { get { return _sortDirection; } }
            protected override PropertyDescriptor SortPropertyCore { get { return _sortProperty; } }
            protected override void RemoveSortCore()
            {
                _sortDirection = ListSortDirection.Ascending; _sortProperty = null; _isSorted = false;
            }
            protected override void ApplySortCore(PropertyDescriptor prop, ListSortDirection direction)
            {
                _sortProperty = prop;
                _sortDirection = direction;
                List<T> list = Items as List<T>;
                if (list == null) return; list.Sort(Compare);
                _isSorted = true;
                OnListChanged(new ListChangedEventArgs(ListChangedType.Reset, -1));
            }
            private int Compare(T lhs, T rhs)
            {
                var result = OnComparison(lhs, rhs);
                if (_sortDirection == ListSortDirection.Descending)
                    result = -result;
                return result;
            }
            private int OnComparison(T lhs, T rhs)
            {
                object lhsValue = lhs == null ? null : _sortProperty.GetValue(lhs);
                object rhsValue = rhs == null ? null : _sortProperty.GetValue(rhs);
                if (lhsValue == null)
                {
                    return (rhsValue == null) ? 0 : -1;
                }
                if (rhsValue == null)
                {
                    return 1;
                }
                if (lhsValue is IComparable) { return ((IComparable)lhsValue).CompareTo(rhsValue); }
                if (lhsValue.Equals(rhsValue))
                {
                    return 0;
                }
                return lhsValue.ToString().CompareTo(rhsValue.ToString());
            }
        }
    }
}
