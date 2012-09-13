using System;
using System.Runtime.Serialization;
using System.Text;

namespace BoxApi.V2.SDK.Model
{
    public class Folder : Entity
    {
        /// <summary>
        /// The user who created this item
        /// </summary>
        UserEntity CreatedBy { get; set; }

        /// <summary>
        /// The time this item was created
        /// </summary>
        DateTime? CreatedAt { get; set; }

        /// <summary>
        /// The this this item (or its contents) were last modified
        /// </summary>
        UserEntity ModifedBy { get; set; }

        /// <summary>
        /// The user who last modified this item
        /// </summary>
        DateTime? ModifiedAt { get; set; }
        
        /// <summary>
        /// The user who owns this item
        /// </summary>
        UserEntity OwnedBy { get; set; }
        
        /// <summary>
        /// The description of the item
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The item size in bytes
        /// </summary>
        public string Size { get; set; }

        /// <summary>
        /// The folder that contains this item
        /// </summary>
        public Entity ParentFolder { get; set; }

        /// <summary>
        /// An array of file or folder objects contained in this folder
        /// </summary>
        public ItemCollection ItemCollection { get; set; }

//        public override string ToString()
//        {
//            StringBuilder sb = new StringBuilder();
//            sb.AppendFormat("type: {0} id: {1} created_by: {2} created_at: {3} modified_by: {4} modified_at: {5} owned_by: {6} name: {7} description: {8} size: {9}",
//                            Type, Id, CreatedBy, CreatedAt.HasValue ? CreatedAt.ToString() : "null", ModifedBy, ModifiedAt.HasValue ? ModifiedAt.ToString() : "null", OwnedBy, Name, Description, Size);
//
//            foreach (Item item in ItemCollection)
//            {
//                if (item != null)
//                {
//                    sb.Append("\n\t");
//                    sb.Append(item.ToString());
//                }
//            }
//            return sb.ToString();
//        }
    }
}