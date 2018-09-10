header_VmJump
vm_jump PROC
	push ebp
	mov ebp, esp	
	
	; read the offset to jump
	push [ebp+arg0]
	call vm_stack_pop_enc

	; modify the vm IP
	mov ebx, [ebp+arg0]
	mov [ebx+vm_ip], eax

	mov ebp, esp
	pop ebp
	ret
vm_jump ENDP
header_end