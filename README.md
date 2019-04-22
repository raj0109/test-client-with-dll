# test-client-with-dll

***emrx.dll*** is the to be used along with your project.

test.cs has reference implementation.
 
```cs
Notification.setBaseURL("http://localhost:8989/"); // Setup  the Server URL. It should be done only once.
await Notification.NewInvoiceGenerated("200A"); // Notification where only invoice number will be sent to the server.
```
