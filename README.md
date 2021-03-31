# Konektilo-Project
**Workstudent Project**  
-This Project uses the vuforia engine to  to recognize and track a parts cabinet to locate parts that are store in it. This application uses the Advanced Model Targets feature of the Vuforia engine that utilizes cloud-based deep learning training process, to produce an Advanced Model Target Database. Such a database contains one or more Model Targets where each contains one or more Guide Views with a recognition range up to 360 degrees. Advanced Model Targets support recognition and tracking of an object from anywhere in the defined recognition range without requiring the user to manually align the view with the physical object. 

-The application also has additional features for the user to choose the required part name/ID from a dropdown list. The application will then visually point the user towards the location where the parts are stored in the cabinet. The information about the location of each part is maintained in a database which is accessed by a Beckhoff PLC. When the location information of the parts is changed in the database the application automatically updates itself in realtime. 
