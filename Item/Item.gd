extends CharacterBody2D

var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")

func _ready():
	velocity.y = -600
	velocity.x = randf_range(-200, 200)
	print_debug(velocity)

# Called every frame. 'delta' is the elapsed time since the previous frame.
func _process(delta):
	if not is_on_floor():
		velocity.y += gravity * delta
		
		if abs(velocity.x) > 0:
			if velocity.x > 0:
				velocity.x -= 1 * delta
			else:
				velocity.x += 1 * delta
	else:
		velocity.x = 0
	
	move_and_slide()


func _on_area_2d_area_entered(area):
	if area is Player:
		#add to the inventory
		print_debug("Beans")
		queue_free()
