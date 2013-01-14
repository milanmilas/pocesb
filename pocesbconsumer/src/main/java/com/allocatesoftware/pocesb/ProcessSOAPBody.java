package com.allocatesoftware.pocesb;

import java.util.List;

import javax.xml.namespace.QName;
import javax.xml.soap.MessageFactory;
import javax.xml.soap.SOAPBody;
import javax.xml.soap.SOAPBodyElement;
import javax.xml.soap.SOAPElement;
import javax.xml.soap.SOAPEnvelope;
import javax.xml.soap.SOAPMessage;
import javax.xml.soap.SOAPPart;
import javax.xml.ws.Holder;

import org.apache.activemq.Message;
import org.apache.camel.Exchange;
import org.apache.camel.Processor;
import org.apache.commons.logging.Log;
import org.apache.commons.logging.LogFactory;
import org.apache.cxf.message.MessageContentsList;
import org.apache.cxf.service.model.BindingOperationInfo;
import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
//import com.sun.messaging.xml.MessageTransformer;
import org.apache.camel.model.dataformat.JaxbDataFormat;
import org.apache.camel.spi.DataFormat; 


public class ProcessSOAPBody implements Processor {
	
	private static final transient Logger LOG = LoggerFactory.getLogger(ProcessSOAPBody.class);
	
	@Override
	@SuppressWarnings("unchecked")
	public void process(Exchange exchange) throws Exception {
        LOG.info("processing exchange in camel");

        /*JaxbDataFormat jaxbDataFormat = new JaxbDataFormat(true);// WARNING two packages for JaxbDataFormat
        jaxbDataFormat.setContextPath("com.allocatesoftware.pocesb");*/
        


        
        //SOAPMessage soapMessage = exchange.getIn().getHeader("CamelCxfMessage", SOAPMessage.class);
/*        SOAPMessage soapMessage = MessageTransformer.SOAPMessageFromJMSMessage((Message)exchange.getIn(), MessageFactory.newInstance());// MessageTransformer.SOAPMessageFromJMSMessage( (Message)exchange.getIn(),
        				 //MessageFactory.newInstance() );
        LOG.info("SOAPMessage-soapMessage "+exchange.getIn());
        SOAPPart sp = soapMessage.getSOAPPart();
        LOG.info("SOAPPart-sp "+sp);
        SOAPEnvelope se = sp.getEnvelope();
        LOG.info("SOAPPart-se "+se);
        SOAPBody sb = se.getBody();
        LOG.info("SOAPPart-sb "+sb);
        String requestText = sb.getFirstChild().getTextContent();
        System.out.println(requestText);
        
        SOAPMessage soapMessageNew = MessageFactory.newInstance().createMessage();
        LOG.info("SOAPMessage-soapMessageNew "+soapMessageNew);
        SOAPBody body = soapMessageNew.getSOAPPart().getEnvelope().getBody();
        LOG.info("SOAPBody-body "+body);
        QName payloadName = new QName("http://allocatesoftware.uk", "DispalyInformation");
        LOG.info("QName-payloadName "+payloadName);
        SOAPBodyElement payload = body.addBodyElement(payloadName);
        LOG.info("SOAPBodyElement-payload "+payload);
        SOAPElement message = payload.addChildElement("message");
        LOG.info("SOAPElement-message "+message);
        message.addTextNode(requestText);
        LOG.info("message "+message);
        exchange.getOut().setBody(body);
        LOG.info("exchange "+exchange);*/
        
        //BindingOperationInfo boi = (BindingOperationInfo)exchange.getProperty(BindingOperationInfo.class.toString());
        //if (boi != null) {
        //    LOG.info("boi.isUnwrapped" + boi.isUnwrapped());
        //}
        // Get the parameters list which element is the holder.
        //MessageContentsList msgList = (MessageContentsList)exchange.getIn().getBody();
        //Holder<String> personId = (Holder<String>)msgList.get(0);
        //Holder<String> ssn = (Holder<String>)msgList.get(1);
        //Holder<String> name = (Holder<String>)msgList.get(2);

/*        if (personId.value == null || personId.value.length() == 0) {
            LOG.info("person id 123, so throwing
             exception");
            // Try to throw out the soap fault message
            org.apache.camel.wsdl_first.types.UnknownPersonFault personFault =
                new org.apache.camel.wsdl_first.types.UnknownPersonFault();
            personFault.setPersonId("");
            org.apache.camel.wsdl_first.UnknownPersonFault fault =
                new org.apache.camel.wsdl_first.UnknownPersonFault("Get the null value of person name", personFault);
            // Since camel has its own exception handler framework, we can't throw the exception to trigger it
            // We just set the fault message in the exchange for camel-cxf component handling and return
            exchange.getOut().setFault(true);
            exchange.getOut().setBody(fault);
            return;
        }*/

        //name.value = "Bonjour";
        //ssn.value = "123";
        LOG.info("setting Bonjour as the response");
        // Set the response message, first element is the return value of the operation,
        // the others are the holders of method parameters
        
        String body = exchange.getIn().getBody(String.class);
        exchange.getOut().setBody("<DispalyInformation xmlns=\"http://allocatesoftware.uk\"><message xmlns=\"http://allocatesoftware.uk\">Hello"
        							+body + "</message></DispalyInformation>");
        //exchange.getOut().setBody(new Object[] {null, personId, ssn, name});

	}
}
