using System;
using System.Collections.Generic;

namespace MyModels
{
    public class WorksData
    {
        // 作品专辑类
        public WorksAlbum Album { get; set; }

        // 作品话题类
        public WorksTopic Topic { get; set; }

        // 话题人员
        public string TopicDebaters { get; set; }

        // 作品分类列表
        public IList<Guid> ClassifyTypeList
        {
            get;
            set;
        }

        //作品媒体具体内容类列表
        public IList<WorksMedia> WorksMediaList
        {
            get;
            set;
        }

        public Guid WorksId { get; set; }

        public Guid? lastViewedId { get; set; }

        public string labelClassifyList { get; set; }
        public string userFormList { get; set; }
    }

    public class WorksMedia
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }

    public class WorksTopic
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }

    public class WorksAlbum
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
