﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4206
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 
namespace epub {
    using System.Xml.Serialization;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="urn:oasis:names:tc:opendocument:xmlns:container", IsNullable=false)]
    public partial class container {
        
        private containerRootfiles rootfilesField;
        
        private string versionField;
        
        /// <remarks/>
        public containerRootfiles rootfiles {
            get {
                return this.rootfilesField;
            }
            set {
                this.rootfilesField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    public partial class containerRootfiles {
        
        private containerRootfilesRootfile rootfileField;
        
        /// <remarks/>
        public containerRootfilesRootfile rootfile {
            get {
                return this.rootfileField;
            }
            set {
                this.rootfileField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="urn:oasis:names:tc:opendocument:xmlns:container")]
    public partial class containerRootfilesRootfile {
        
        private string fullpathField;
        
        private string mediatypeField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("full-path")]
        public string fullpath {
            get {
                return this.fullpathField;
            }
            set {
                this.fullpathField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute("media-type")]
        public string mediatype {
            get {
                return this.mediatypeField;
            }
            set {
                this.mediatypeField = value;
            }
        }
    }
}
