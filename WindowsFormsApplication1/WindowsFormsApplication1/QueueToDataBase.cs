

public class QueueToDataBase{

//First Column is name
//Event type
//Location
//time
//description
//Number of players/ Number of players required
//
//
	private string name;
	private string eventType;
	private string location;
	private string description;
	private int numOfPlayers;
	private int requiredNumOfPlayers;


	public void Name(String name){
		get{
			return name;
		}
		set{
			this.name = name;
		}
	}
	public void NumOfPlayers(int numOfPlayers){
		get{
			return numOfPlayers;
		}
		set{
			this.numOfPlayers = numOfPlayers;
		}
	}

	public void RequiredNumOfPlayers(int requiredNumOfPlayers){
		get{
			return requiredNumOfPlayers;
		}
		set{
			this.requiredNumOfPlayers = requiredNumOfPlayers;
		}
	}
	public void EventType(String eventType){
		get{
			return eventType;
		}
		set{
			this.eventType = eventType;
		}
	}

	public void Location(String location){
		get{
			return location;
		}
		set{
			this.location = location;
		}
	}

	public void Description(String description){
		get{
			return description;
		}
		set{
			this.description = description;
		}
	}
}