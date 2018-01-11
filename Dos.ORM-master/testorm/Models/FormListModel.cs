using Dos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testorm.Models
{
    public class FormListModel
    {

        public Form_Head head { get; set; }
        public List<Form_List> formList { get; set; }
        public List<Container_number> container { get; set; }

    }
    public class HeadListModel
    {

        public DC_EP_DEC_HEAD_O head { get; set; }
        public HeadListModel()
        {
            containers = new List<DC_EP_DEC_CONTAINER>();
            dtls = new List<DC_EP_DEC_DTL>();
        } 
        public List<DC_EP_DEC_CONTAINER> containers { get; set; }
        public List<DC_EP_DEC_DTL> dtls { get; set; }
    }
    public class head_id
    {
        public long deh_id { get; set; }
    }
}