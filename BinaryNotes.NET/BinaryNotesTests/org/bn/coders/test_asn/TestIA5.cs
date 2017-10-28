
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
    [ASN1BoxedType ( Name = "TestIA5") ]
    public class TestIA5: IASN1PreparedElement {

            private String val;
    
            [ASN1String( Name = "TestIA5", 
        StringType =  UniversalTags.IA5String , IsUCS = false) ]
            
            public String Value
            {
                get { return val; }
                set { val = value; }
            }
            
            public TestIA5() {
            }

            public TestIA5(String val) {
                this.val = val;
            }            

            public void initWithDefaults()
	    {
	    }


            private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TestIA5));
            public IASN1PreparedElementData PreparedData {
            	get { return preparedData; }
            }

    }
            
}
