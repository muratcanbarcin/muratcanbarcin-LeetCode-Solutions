class Solution:
    def asteroidCollision(self, asteroids: list[int]) -> list[int]:
        stack = []
        
        for ast in asteroids:
            yasiyorMu = True
            
            while stack and stack[-1] > 0 and ast < 0:
                if stack[-1] < abs(ast):
                    stack.pop()
                    continue
                elif stack[-1] == abs(ast):
                    stack.pop()
                
                yasiyorMu = False
                break
            
            if yasiyorMu:
                stack.append(ast)
        
        return stack