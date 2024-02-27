extends CharacterBody2D

var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")

func _ready():
	velocity.y = -600

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	if not is_on_floor():
		velocity.y += gravity * delta
	
	move_and_slide()


func _on_area_2d_area_entered(area):
	if area is Player:
		#add to the inventory
		print_debug("Beans")
		queue_free()
