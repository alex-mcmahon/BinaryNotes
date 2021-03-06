
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

namespace org.bn.coders.test_asn {


    [ASN1PreparedElement]
    [ASN1BoxedType ( Name = "TestLongTag") ]
    public class TestLongTag: IASN1PreparedElement {
            
           
        private long  val;

        [ASN1Integer( Name = "" )]
    
        [ASN1Element ( Name = "TestLongTag", IsOptional =  false , HasTag =  true, Tag = 15123, 
        TagClass =  TagClasses.Application  , HasDefaultValue =  false )  ]
    
        public long Value
        {
                get { return val; }        
                    
                set { val = value; }
                        
        }            

                    
        
        public TestLongTag ()
        {
        }

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TestLongTag));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

        
    }
            
}
