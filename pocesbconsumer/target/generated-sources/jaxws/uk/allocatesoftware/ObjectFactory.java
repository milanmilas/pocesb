
package uk.allocatesoftware;

import javax.xml.bind.JAXBElement;
import javax.xml.bind.annotation.XmlElementDecl;
import javax.xml.bind.annotation.XmlRegistry;
import javax.xml.namespace.QName;


/**
 * This object contains factory methods for each 
 * Java content interface and Java element interface 
 * generated in the uk.allocatesoftware package. 
 * <p>An ObjectFactory allows you to programatically 
 * construct new instances of the Java representation 
 * for XML content. The Java representation of XML 
 * content can consist of schema derived interfaces 
 * and classes representing the binding of schema 
 * type definitions, element declarations and model 
 * groups.  Factory methods for each of these are 
 * provided in this class.
 * 
 */
@XmlRegistry
public class ObjectFactory {

    private final static QName _DispalyInformationMessage_QNAME = new QName("http://allocatesoftware.uk", "message");

    /**
     * Create a new ObjectFactory that can be used to create new instances of schema derived classes for package: uk.allocatesoftware
     * 
     */
    public ObjectFactory() {
    }

    /**
     * Create an instance of {@link DispalyInformation }
     * 
     */
    public DispalyInformation createDispalyInformation() {
        return new DispalyInformation();
    }

    /**
     * Create an instance of {@link DispalyInformationResponse }
     * 
     */
    public DispalyInformationResponse createDispalyInformationResponse() {
        return new DispalyInformationResponse();
    }

    /**
     * Create an instance of {@link JAXBElement }{@code <}{@link String }{@code >}}
     * 
     */
    @XmlElementDecl(namespace = "http://allocatesoftware.uk", name = "message", scope = DispalyInformation.class)
    public JAXBElement<String> createDispalyInformationMessage(String value) {
        return new JAXBElement<String>(_DispalyInformationMessage_QNAME, String.class, DispalyInformation.class, value);
    }

}
