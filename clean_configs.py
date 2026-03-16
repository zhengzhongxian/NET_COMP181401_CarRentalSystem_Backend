import os
import re

# Configuration directory
config_dir = r"c:\Users\ADMIN\Desktop\SPNC\NET_CarRentalSystem\NET_CarRentalSystem.Infrastructure\Persistence\Configurations"

# Properties to remove (IAuditable and ISoftDelete)
properties_to_remove = [
    "CreatedAt", "CreatedBy", "UpdatedAt", "UpdatedBy",  # IAuditable
    "IsDeleted", "DeletedAt", "DeletedBy"  # ISoftDelete
]

# Column names to look for
column_names = [
    "created_at", "created_by", "updated_at", "updated_by",
    "is_deleted", "deleted_at", "deleted_by"
]

def should_remove_block(lines, start_idx):
    """Check if a property configuration block should be removed"""
    # Look for Property(...) pattern
    if start_idx >= len(lines):
        return False
    
    line = lines[start_idx].strip()
    
    # Check if it's a Property configuration for one of our target properties
    for prop in properties_to_remove:
        if f"Property(vm => vm.{prop})" in line or \
           f"Property(v => v.{prop})" in line or \
           f"Property(t => t.{prop})" in line or \
           f"Property(c => c.{prop})" in line or \
           f"Property(b => b.{prop})" in line or \
           f"Property(bv => bv.{prop})" in line or \
           f"Property(l => l.{prop})" in line or \
           f"Property(f => f.{prop})" in line or \
           f"Property(r => r.{prop})" in line or \
           f"Property(u => u.{prop})" in line or \
           f"Property(i => i.{prop})" in line or \
           f"Property(p => p.{prop})" in line or \
           f"Property(w => w.{prop})" in line:
            return True
    
    # Also check by column name
    for col in column_names:
        if f'HasColumnName("{col}")' in line:
            return True
    
    return False

def remove_property_block(lines, start_idx):
    """Remove a complete property configuration block"""
    end_idx = start_idx
    
    # Find the end of this property block (ends with semicolon)
    while end_idx < len(lines):
        if ';' in lines[end_idx]:
            end_idx += 1
            break
        end_idx += 1
    
    # Check if next line is empty, remove it too
    if end_idx < len(lines) and lines[end_idx].strip() == '':
        end_idx += 1
    
    return end_idx

def clean_configuration_file(filepath):
    """Remove IAuditable and ISoftDelete property configurations from a file"""
    with open(filepath, 'r', encoding='utf-8') as f:
        lines = f.readlines()
    
    new_lines = []
    i = 0
    removed_count = 0
    
    while i < len(lines):
        if should_remove_block(lines, i):
            # Find and skip the entire property block
            end_idx = remove_property_block(lines, i)
            removed_count += 1
            i = end_idx
        else:
            new_lines.append(lines[i])
            i += 1
    
    if removed_count > 0:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.writelines(new_lines)
        print(f"✓ {os.path.basename(filepath)}: Removed {removed_count} property configurations")
        return True
    else:
        print(f"  {os.path.basename(filepath)}: No changes needed")
        return False

def main():
    print("Cleaning IAuditable and ISoftDelete configurations...\n")
    
    total_files = 0
    modified_files = 0
    
    for filename in os.listdir(config_dir):
        if filename.endswith("Configuration.cs"):
            filepath = os.path.join(config_dir, filename)
            total_files += 1
            if clean_configuration_file(filepath):
                modified_files += 1
    
    print(f"\n✓ Done! Modified {modified_files}/{total_files} files")

if __name__ == "__main__":
    main()
