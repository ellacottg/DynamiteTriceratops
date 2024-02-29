extends CharacterBody2D
# Commit Justin

const SPEED = 600.0
const JUMP_VELOCITY = -1600.0

# Get the gravity from the project settings to be synced with RigidBody nodes.
var gravity = ProjectSettings.get_setting("physics/2d/default_gravity")



func _physics_process(delta):
	
			# Add the gravity.
		if not is_on_floor():
			velocity.y += gravity * delta

		# Handle jump.
		if Input.is_action_just_pressed("ui_accept") and is_on_floor():
			velocity.y = JUMP_VELOCITY
		
		#check for attack
		if Input.is_action_just_released("Attack"):
			$AttackComponent/CollisionShape2D.disabled = false
		else:
			$AttackComponent/CollisionShape2D.disabled = true

		# Get the input direction and handle the movement/deceleration.
		# As good practice, you should replace UI actions with custom gameplay actions.
		var direction = Input.get_axis("ui_left", "ui_right")
		if direction:
			velocity.x += direction * SPEED * delta
			if abs(velocity.x) > SPEED:
				velocity.x = SPEED * direction
		else:
			velocity.x = move_toward(velocity.x, 0, SPEED * delta * 10)

		move_and_slide()
