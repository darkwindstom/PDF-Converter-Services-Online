/* 
 * Muhimbi PDF
 *
 * Convert, Merge, Watermark, Secure and OCR files.
 *
 * OpenAPI spec version: 9.9
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace Muhimbi.PDF.Online.Client.Model
{
    /// <summary>
    /// Individual files
    /// </summary>
    [DataContract]
    public partial class ProcessedFiles :  IEquatable<ProcessedFiles>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessedFiles" /> class.
        /// </summary>
        /// <param name="ProcessedFileName">Name of the file with the extension..</param>
        /// <param name="ProcessedFileContent">File generated by the Muhimbi converter..</param>
        public ProcessedFiles(string ProcessedFileName = default(string), byte[] ProcessedFileContent = default(byte[]))
        {
            this.ProcessedFileName = ProcessedFileName;
            this.ProcessedFileContent = ProcessedFileContent;
        }
        
        /// <summary>
        /// Name of the file with the extension.
        /// </summary>
        /// <value>Name of the file with the extension.</value>
        [DataMember(Name="processed_file_name", EmitDefaultValue=false)]
        public string ProcessedFileName { get; set; }
        /// <summary>
        /// File generated by the Muhimbi converter.
        /// </summary>
        /// <value>File generated by the Muhimbi converter.</value>
        [DataMember(Name="processed_file_content", EmitDefaultValue=false)]
        public byte[] ProcessedFileContent { get; set; }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProcessedFiles {\n");
            sb.Append("  ProcessedFileName: ").Append(ProcessedFileName).Append("\n");
            sb.Append("  ProcessedFileContent: ").Append(ProcessedFileContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as ProcessedFiles);
        }

        /// <summary>
        /// Returns true if ProcessedFiles instances are equal
        /// </summary>
        /// <param name="other">Instance of ProcessedFiles to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ProcessedFiles other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.ProcessedFileName == other.ProcessedFileName ||
                    this.ProcessedFileName != null &&
                    this.ProcessedFileName.Equals(other.ProcessedFileName)
                ) && 
                (
                    this.ProcessedFileContent == other.ProcessedFileContent ||
                    this.ProcessedFileContent != null &&
                    this.ProcessedFileContent.Equals(other.ProcessedFileContent)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.ProcessedFileName != null)
                    hash = hash * 59 + this.ProcessedFileName.GetHashCode();
                if (this.ProcessedFileContent != null)
                    hash = hash * 59 + this.ProcessedFileContent.GetHashCode();
                return hash;
            }
        }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        { 
            yield break;
        }
    }

}