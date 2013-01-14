package uk.allocatesoftware;

import javax.jws.WebMethod;
import javax.jws.WebParam;
import javax.jws.WebService;
import javax.xml.bind.annotation.XmlSeeAlso;
import javax.xml.ws.Action;
import javax.xml.ws.RequestWrapper;
import javax.xml.ws.ResponseWrapper;

/**
 * This class was generated by Apache CXF 2.7.0
 * 2013-01-11T13:16:41.955Z
 * Generated source version: 2.7.0
 * 
 */
@WebService(targetNamespace = "http://allocatesoftware.uk", name = "ISubscriberService")
@XmlSeeAlso({ObjectFactory.class, com.microsoft.schemas._2003._10.serialization.ObjectFactory.class})
public interface ISubscriberService {

    @Action(input = "http://allocatesoftware.uk/ISubscriberService/DispalyInformation", output = "http://allocatesoftware.uk/ISubscriberService/DispalyInformationResponse")
    @RequestWrapper(localName = "DispalyInformation", targetNamespace = "http://allocatesoftware.uk", className = "uk.allocatesoftware.DispalyInformation")
    @WebMethod(operationName = "DispalyInformation", action = "http://allocatesoftware.uk/ISubscriberService/DispalyInformation")
    @ResponseWrapper(localName = "DispalyInformationResponse", targetNamespace = "http://allocatesoftware.uk", className = "uk.allocatesoftware.DispalyInformationResponse")
    public void dispalyInformation(
        @WebParam(name = "message", targetNamespace = "http://allocatesoftware.uk")
        java.lang.String message
    );
}