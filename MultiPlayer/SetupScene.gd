extends Control

@export var Address = "127.0.0.1"
@export var port = 3229
var peer
# Called when the node enters the scene tree for the first time.
func _ready():
	multiplayer.peer_connected.connect(peer_connected)
	multiplayer.peer_disconnected.connect(peer_disconnected)
	multiplayer.connected_to_server.connect(connected_to_server)
	multiplayer.connection_failed.connect(connection_failed)

	
func peer_connected(id):
	print("player Connected " + str(id))
	
func peer_disconnected(id):
	print("player Disconnected " + id)
	
func connected_to_server():
	print("Connected to the server! ")
	
func connection_failed():
	print("Couldnt Connect!! ")

func _on_btn_host_pressed():
	peer = ENetMultiplayerPeer.new()
	var error = peer.create_server(port,4)
	if error != OK:
		print("cannot host:"+ error)
		return
	peer.get_host().compress(ENetConnection.COMPRESS_RANGE_CODER)
	
	multiplayer.set_multiplayer_peer(peer)
	print("Waiting For player")
	
func _on_btn_join_pressed():
	peer = ENetMultiplayerPeer.new()
	peer.create_client(Address,port)
	peer.get_host().compress(ENetConnection.COMPRESS_RANGE_CODER)
	multiplayer.set_multiplayer_peer(peer)
	
func _on_btn_start_game_pressed():
	StartGame.rpc()
@rpc("any_peer","call_local")	
func StartGame():
	var scene = load("res://Levels/testLevel.tscn").instantiate()
	get_tree().root.add_child(scene)
	self.hide()
