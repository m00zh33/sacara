header_VmSub
vm_sub PROC
	push ebp
	mov ebp, esp	
	
	; read the first operand
	push [ebp+arg0]
	call_vm_stack_pop_enc
	push eax

	; read the second operand
	push [ebp+arg0]
	call_vm_stack_pop_enc

	; do operation
	pop ecx
	sub ecx, eax

	; push result
	push ecx
	push [ebp+arg0]
	call_vm_stack_push_enc

	mov esp, ebp
	pop ebp
	ret
vm_sub ENDP
header_marker