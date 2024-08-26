<?php

class member{

    public $id;
    public $Name;
    public $Username;

    function set_name($name){$this->name =$name;}
    function set_username($Username){$this->Username =$Username;}
    function set_id($id){$this->id =$id;}


}

function memberUpsert($member)
{

    include_once("../connections/connections.php");

    $Name = $member->name;
    $Username =$member->Username;
    $inID = $member->id;
    $conn = connection();
    $sql ="";

    try {       
        $conn->begin_transaction();    
        if((int)$inID == 0)
        {
            echo $inID;
            $sql = "INSERT INTO user ( `Name`, `Username`) VALUES ('$Name','$Username')";
        }
        else{
            $sql = "UPDATE user Set `Name`='$Name',`Username`='$Username' where `ID` = $member->id ";
        }
        //tesst
        $conn->query($sql) or die ($conn->error);
        $conn->commit();
        }
        
        //catch exception
        catch(Exception $e) { 
            $conn->rollback(); 
          echo 'Message: ' .$e->getMessage();
        }    
}

?>