using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace _110_1HW3{
    public partial class WebForm1 : System.Web.UI.Page{
        protected void Page_Load(object sender, EventArgs e){
            int[,] ia_Map = new int[10, 10];
            int[] ia_MIndex = new int[10] { 0, 7, 13, 28, 44, 62, 74, 75, 87, 90};
            mt_MarkBomb(ref ia_Map, ref ia_MIndex, ref ia_Map);

            for (){
                Response.Write();
            }

        }

        public void mt_MarkBomb(ref int[,] ia_Map, ref int[,] ia_Map) {
            for (int i_ct = 0; ...) {  //Loop 1D
                int i_RI = 0;
                int i_CI = 0;
                mtGet(ia_MIndex[i_ct], ref i_RI, ref i_CI);
            }
        }
        
        public void mt_Get(int i_Index, ref int i_RI, ref int i)CI) {
        }
    
        public void mt_IsSuccess(ref int[,] ia_Map, ref int i_RI, ref int i_CI) { 
        }
    }
}