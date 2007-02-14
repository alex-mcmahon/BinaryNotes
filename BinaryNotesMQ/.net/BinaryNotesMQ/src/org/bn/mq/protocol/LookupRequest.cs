
//
// This file was generated by the BinaryNotes compiler.
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace org.bn.mq.protocol {


    [ASN1PreparedElement]
    [ASN1Sequence ( Name = "LookupRequest", IsSet = false  )]
    public class LookupRequest : IASN1PreparedElement {
                    
	private string supplierName_ ;
	[ASN1String( Name = "", 
        StringType =  UniversalTags.PrintableString , IsUCS = false )][ASN1ValueRangeConstraint ( 
		Min = 0L, 
		Max = 255L ) ]
	    
        [ASN1Element ( Name = "supplierName", IsOptional =  false , HasTag =  false  , HasDefaultValue =  false )  ]
    
        public string SupplierName
        {
            get { return supplierName_; }
            set { supplierName_ = value;  }
        }
        
                
  

            public void initWithDefaults() {
                
            }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(LookupRequest));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

            
    }
            
}