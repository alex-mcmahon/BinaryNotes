/*
 Copyright 2006-2011 Abdulla Abdurakhmanov (abdulla@latestbit.com)
 
 Licensed under the Apache License, Version 2.0 (the "License");
 you may not use this file except in compliance with the License.
 You may obtain a copy of the License at

 http://www.apache.org/licenses/LICENSE-2.0

 Unless required by applicable law or agreed to in writing, software
 distributed under the License is distributed on an "AS IS" BASIS,
 WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 See the License for the specific language governing permissions and
 limitations under the License.
 */
package org.bn.metadata;

import java.io.InputStream;
import java.io.OutputStream;
import org.bn.annotations.ASN1ObjectIdentifier;
import org.bn.coders.DecodedObject;
import org.bn.coders.ElementInfo;
import org.bn.coders.IASN1TypesDecoder;
import org.bn.coders.IASN1TypesEncoder;

public class ASN1ObjectIdentifierMetadata extends ASN1FieldMetadata {

    public ASN1ObjectIdentifierMetadata(String name) {
        super(name);
    }

    public ASN1ObjectIdentifierMetadata(ASN1ObjectIdentifier annotation) {
        this(annotation.name());
    }

    @Override
    public int encode(IASN1TypesEncoder encoder, Object object, OutputStream stream, ElementInfo elementInfo) throws Exception {
        return encoder.encodeObjectIdentifier(object, stream, elementInfo);
    }

    @Override
    public DecodedObject<?> decode(IASN1TypesDecoder decoder, DecodedObject<Integer> decodedTag, Class<?> objectClass, ElementInfo elementInfo, InputStream stream) throws Exception {
        return decoder.decodeObjectIdentifier(decodedTag, objectClass, elementInfo, stream);
    }
}
